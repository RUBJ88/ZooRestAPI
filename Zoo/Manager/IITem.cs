using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Zoo.Manager
{
    public interface IITem
    {
        public IEnumerable<Item> GetWithFilter(ItemsFeature filter);

        public IEnumerable<Item> GetFromSubstring(String substring);
    }
}
