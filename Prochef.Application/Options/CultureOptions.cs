using System;
using System.Collections.Generic;
using System.Text;

namespace Prochef.Application.Options
{
    public class CultureOptions
    {
        public const string SectionName = "CultureOptions";

        public string[] SupportedCultures { get; set; }
        public string DefaultCulture { get; set; }
    }
}
