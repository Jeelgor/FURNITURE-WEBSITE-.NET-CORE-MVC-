using FURNITURE.Data;
using FURNITURE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ProductsController : Controller
{
    private readonly FurnitureDbContext DbContext;

    public ProductsController(FurnitureDbContext dbContext)
    {
        this.DbContext = dbContext;
    }

   /* [HttpPost]

    public async Task<IActionResult> StudyAdmin(ProductsDataView viewModel)
    {
        {
            var furdata = new FurnitureDataModel
            {
                Name = viewModel.Name,
                Price = viewModel.Price,
                ImagePath = viewModel.ImagePath,

            };
            await DbContext.FurnitureData.AddAsync(furdata);
            await DbContext.SaveChangesAsync();
        }

        return View();
    }*/


    [HttpGet]
    public async Task<IActionResult> StudyTable()
    {
        var studyProducts = await DbContext.ProductsData.ToListAsync();
        return View(studyProducts);
    }
    [HttpGet]
    public async Task<IActionResult> SofaPage()
    {
        var studyProducts1 = await DbContext.SofaData.ToListAsync();
        return View(studyProducts1);
    }
    [HttpGet]
    public async Task<IActionResult> ChairPage()
    {
        var studyProducts2 = await DbContext.Chairtbl.ToListAsync();
        return View(studyProducts2);
    }
}



