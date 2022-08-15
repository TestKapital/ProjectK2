using BlazorServerAppK.Pages;
using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerAppK.UnitTest
{
    public class CounterTest
    {
        public void CounterComponentRendersCorrectly()
        {
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<Counter>();
            cut.MarkupMatches("<h1>Counter</h1>\n<p role=\"status\">Current count: 0</p>\n<button class=\"btn btn-primary\" >Click me</button>");
        }
    }
}
