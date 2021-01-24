﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyApp.Pages
{
    public class Index_Tests : MyAppWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
