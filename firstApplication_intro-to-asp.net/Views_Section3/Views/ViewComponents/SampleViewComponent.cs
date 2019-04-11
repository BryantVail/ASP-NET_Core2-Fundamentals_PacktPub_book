using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views_Section3.Views.ViewComponents
{
    public class SampleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string additionalData)
        {
            var data = GetSampleData(additionalData);
            return View(data);
        }

        //dummy data on a dummy private method
        //will be replaced by a method to gather data I believe
        private List<string> GetSampleData(string additionalData)
        {
            List<string> data = new List<string>();
            data.Add("One");
            data.Add("Two");
            data.Add("Three");
            data.Add(additionalData);
            return data;
        }
    }
}
