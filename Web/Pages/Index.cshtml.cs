using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using Web.Services;

namespace Web.Pages
{
public class IndexModel : PageModel
{
    private readonly IPersonneRepositoryAsync _personne;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRazorRenderService _renderService;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, IPersonneRepositoryAsync personne, IUnitOfWork unitOfWork, IRazorRenderService renderService)
    {
        _logger = logger;
        _personne = personne;
        _unitOfWork = unitOfWork;
        _renderService = renderService;
    }
    public IEnumerable<Personne> Personnes { get; set; }
    public void OnGet()
    {
    }
    public async Task<PartialViewResult> OnGetViewAllPartial()
    {
        Personnes = await _personne.GetAllAsync();
        return new PartialViewResult
        {
            ViewName = "_ViewAll",
            ViewData = new ViewDataDictionary<IEnumerable<Personne>>(ViewData, Personnes)
        };
    }
    public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
    {
        if (id == 0)
            return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEdit", new Personne()) });
        else
        {
            var thisPersonne = await _personne.GetByIdAsync(id);
            return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEdit", thisPersonne) });
        }
    }
    public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Personne personne)
    {
        if (ModelState.IsValid)
        {
            if (id == 0)
            {
                await _personne.AddAsync(personne);
                await _unitOfWork.Commit();
            }
            else
            {
                await _personne.UpdateAsync(personne);
                await _unitOfWork.Commit();
            }
            Personnes = await _personne.GetAllAsync();
            var html = await _renderService.ToStringAsync("_ViewAll", Personnes);
            return new JsonResult(new { isValid = true, html = html });
        }
        else
        {
            var html = await _renderService.ToStringAsync("_CreateOrEdit", personne);
            return new JsonResult(new { isValid = false, html = html });
        }
    }
    public async Task<JsonResult> OnPostDeleteAsync(int id)
    {
        var personne = await _personne.GetByIdAsync(id);
        await _personne.DeleteAsync(personne);
        await _unitOfWork.Commit();
        Personnes = await _personne.GetAllAsync();
        var html = await _renderService.ToStringAsync("_ViewAll", Personnes);
        return new JsonResult(new { isValid = true, html = html });
    }
}
}
