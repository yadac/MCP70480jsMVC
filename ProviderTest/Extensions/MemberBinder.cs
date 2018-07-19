using System.Web.Mvc;
using Member = ProviderTest.Models.Member;

namespace ProviderTest.Extensions
{
    public class MemberBinder : IModelBinder
    {
        public object BindModel(ControllerContext context,
            ModelBindingContext bindingContext)
        {
            var name = bindingContext.ValueProvider.GetValue("name").ConvertTo(typeof(string)).ToString();
            var age = (int)bindingContext.ValueProvider.GetValue("age").ConvertTo(typeof(int));
            var mem = new Member()
            {
                Id = 1,
                Name = name,
                Age = age,
            };
            return mem;
        }
    }
}