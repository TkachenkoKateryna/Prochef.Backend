using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Prochef.Application.Interfaces;
using Prochef.Core.Constants;
using Prochef.Core.Dtos.Response;
using Prochef.Core.Entities;
using Prochef.Core.Interfaces.Repositories;

namespace Prochef.Application.Services
{
    public class MenuService : IMenuService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly Func<IQueryable<Menu>, IIncludableQueryable<Menu, object>> _menuIncludes;
        private readonly Func<IQueryable<MenuItem>, IIncludableQueryable<MenuItem, object>> _menuItemsIncludes;
        public MenuService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
            _menuIncludes = menu => menu.Include(m => m.Sections)
                                                .ThenInclude(s => s.MenuItems)
                                                .ThenInclude(m => m.Ingredients)
                                                .ThenInclude(ig => ig.Product)
                                                .ThenInclude(p => p.Place);

        }

        public MenuResponse GetCurrentMenu(int menuId)
        {

            var menu = _uow.GetRepository<Menu>().FirstOrDefault(m => m.Id == menuId, _menuIncludes);

            var menuResponse = new MenuResponse {MenuItems = new List<MenuItemResponse>(), Name = menu.Title};

            foreach (var sec in menu.Sections)
            {
                foreach (var menuItem in sec.MenuItems)
                {
                    var item = _mapper.Map<MenuItemResponse>(menuItem);

                    if (DateTime.Now.TimeOfDay > new TimeSpan(21, 0, 0) && menuItem.TimeOfTheDay == TimeOfTheDay.Breakfast)
                    {
                        menuItem.Show = false;
                    }
                    else
                    {
                        foreach (var ingredient in menuItem.Ingredients)
                        {

                            if (ingredient.Product.State == State.Spoiled || ingredient.Product.QuantityInStock < ingredient.Weight)
                            {
                                menuItem.Show = false;
                            }
                            else if (DateTime.Now.Day - ingredient.Product.DeliveryDate.Day == ingredient.Product.TermOfUse)
                            {
                                item.Price -= (item.Price * 30 / 100);
                            }
                            else if (ingredient.Product.State == State.NeedToBeUsed)
                            {
                                item.Price -= (item.Price * 15 / 100);
                            }
                        }
                    }

                    if (menuItem.Show)
                    {
                       
                        menuResponse.MenuItems.Add(item);
                    }
                }
            }

            return menuResponse;
        }
    }
}
