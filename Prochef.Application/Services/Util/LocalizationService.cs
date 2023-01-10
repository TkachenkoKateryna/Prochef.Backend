using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Extensions.Localization;

namespace Prochef.Application.Services.Util
{
    public class LocalizationService : IStringLocalizer
    {
        private readonly Dictionary<string, Dictionary<string, string>> _resources;

        public LocalizationService()
        {
            var enDictionary = GetEnglishLocalizationDictionary();
            var uaDictionary = GetUkrainianLocalizationDictionary();

            _resources = new Dictionary<string, Dictionary<string, string>>
            {
                {"en", enDictionary},
                {"ua", uaDictionary}
            };
        }

        public LocalizedString this[string name]
        {
            get
            {
                var currentCulture = CultureInfo.CurrentUICulture;
                var val = "";
                if (_resources.ContainsKey(currentCulture.Name))
                {
                    if (_resources[currentCulture.Name].ContainsKey(name))
                    {
                        val = _resources[currentCulture.Name][name];
                    }
                }

                return new LocalizedString(name, val);
            }
        }

        public LocalizedString this[string name, params object[] arguments] => this[name];

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            var currentCulture = CultureInfo.CurrentCulture.Name;
            return _resources[currentCulture].Select((pair) => new LocalizedString(pair.Key, pair.Value));
        }

        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            return this;
        }

        private Dictionary<string, string> GetUkrainianLocalizationDictionary()
        {
            var dictionary = new Dictionary<string, string>();

            AddUkrainianValidationMessages(dictionary);

            return dictionary;
        }

        private Dictionary<string, string> GetEnglishLocalizationDictionary()
        {
            var dictionary = new Dictionary<string, string>();

            AddEnglishValidationMessages(dictionary);

            return dictionary;
        }

        private void AddUkrainianValidationMessages(IDictionary<string, string> dictionary)
        {
            dictionary.Add("The email is incorrect.", "Адреса електронної пошти введена некоректно.");
            dictionary.Add("The password field must not be empty.", "Пароль є обов'язковим для заповнення.");
            dictionary.Add("The name field must not be empty.", "Назва є обов'язковою для заповнення.");
            dictionary.Add("The city field must not be empty.", "Поле міста є обов'язковим для заповнення.");
            dictionary.Add("The country field must not be empty.", "Поле країни є обов'язковим для заповнення.");
            dictionary.Add("Chain with such name already exists.", " Мережа з таким ім'ям вже існує.");
            dictionary.Add("Chain with id was not found.", "Мережа с даним номер не було знайдена");
            dictionary.Add("Restaurant with such name and address already exists.",
                "Рестрон з таким ім'ям та адресою вже існує");
            dictionary.Add("Restaurants with id was not found.", "Ресторан з таким айди не був знайден");
            dictionary.Add("The phone field must not be empty.", "Поле телефону повинно бути заповнене");
            dictionary.Add("Chain must be selected", "Мережа повинна бути обрана.");
            dictionary.Add("Menu must be selected", "Меню повинне бути обране.");
            dictionary.Add("Place must be selected", "Місто зберігання повинне бути обране.");
            dictionary.Add("Category must be selected", "Категорія повинна бути обрана.");
            dictionary.Add("Product with such name already exists.", "Продукт з таким ім'ям вже існує");
            dictionary.Add("Product with id was not found.", "Продукт с таким номером не був знайдений");
        }

        private void AddEnglishValidationMessages(IDictionary<string, string> dictionary)
        {
            dictionary.Add("The email is incorrect.", "The email is incorrect.");
            dictionary.Add("The password field must not be empty.", "The password field must not be empty.");
            dictionary.Add("The name field must not be empty.", "The name field must not be empty.");
            dictionary.Add("The city field must not be empty.", "The city field must not be empty.");
            dictionary.Add("The country field must not be empty.", "The country field must not be empty.");
            dictionary.Add("Chain with such name already exists.", " Chain with such name already exists.");
            dictionary.Add("Chain with id was not found.", "Chain with id was not found.");
            dictionary.Add("Restaurant with such name and address already exists.",
                "Restaurant with such name and address already exists.");
            dictionary.Add("Restaurants with id was not found.", "Restaurants with id was not found.");
            dictionary.Add("The phone field must not be empty.", "The phone field must not be empty.");
            dictionary.Add("Chain must be selected", "Chain must be selected");
            dictionary.Add("Menu must be selected", "Menu must be selected");
            dictionary.Add("Product with such name already exists.", "Product with such name already exists.");
            dictionary.Add("Product with id was not found.", "Product with id was not found.");
            dictionary.Add("Place must be selected", "Place must be selected");
            dictionary.Add("Category must be selected", "Category must be selected");
        }
    }
}
