using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using CustomData.Data.Northwind;

namespace CustomData.Data {
    [Route("api /[controller] /[action]")]
    public class DataGridWebApiController : Controller {
        NorthwindContext _nwind;

        [HttpGet]
        public object CustomersLookup(DataSourceLoadOptions loadOptions) {
            var lookup = from i in _nwind.Customers
                         let text = i.CompanyName + " (" + i.Country + ")"
                         orderby i.CompanyName
                         select new {
                             Value = i.CustomerId,
                             Text = text
                         };

            return DataSourceLoader.Load(lookup, loadOptions);
        }
        // ...
    }
}
