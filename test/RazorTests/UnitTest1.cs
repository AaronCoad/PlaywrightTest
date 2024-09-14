using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RazorTests;

[TestClass]
public class ExampleTest : PageTest
{
    [TestMethod]
    public async Task HasTitle()
    {
        await Page.GotoAsync("http://localhost:5273");
        await Page.ScreenshotAsync(new()
        {
            Path = "screenshot-hastitle.png"
        });

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Home page"));
    }

    [TestMethod]
    public async Task GetStartedLink()
    {
        await Page.GotoAsync("http://localhost:5273");

        // Click the get started link.
        await Page.GetByRole(AriaRole.Link, new() { Name = "learn" }).ClickAsync();

        // Expects page to have a heading with the name of Installation.
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "ASP.NET documentation" })).ToBeVisibleAsync();
        
        await Page.ScreenshotAsync(new()
        {
            Path = "screenshot-link.png"
        });
    } 
}