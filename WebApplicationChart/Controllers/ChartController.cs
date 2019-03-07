using System.Web.Helpers;
using System.Web.Mvc;

namespace WebApplicationChart.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateCountryGdpBar()
        {
            var chart = new Chart(width: 300, height: 200, theme: ChartTheme.Blue)
                .AddTitle("GDP current prices in Billions($)")
                .AddSeries(
                    chartType: "column",
                    name: "StudyType",
                    xValue: new[] {"USA", "China", "Japan", "Germany", "UK", "France", "South Korea"},
                    yValues: new[] {"2345", "23423", "5676", "4677", "789", "234234", "12312 "})
                .GetBytes("png");
            return File(chart, "image/bytes");
        }
    }
}