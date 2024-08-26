using AutoMapper;
using Ideal.Manager.Contract;
using Ideal.Model.Models;
using Ideal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Drawing2D;

namespace Ideal.Controllers
{
    public class SampleController : Controller
    {
        private readonly ISampleManager _iSampleManager;
        private readonly IMapper _iMapper;

        public SampleController(ISampleManager iSampleManager, IMapper iMapper)
        {
            _iSampleManager = iSampleManager;
            _iMapper = iMapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SampleViewModel>>> Index()
        {
            IEnumerable<SampleViewModel> getAllSamples = _iMapper.Map<IEnumerable<SampleViewModel>>
                                                         (await _iSampleManager.GetAll());

            return View(getAllSamples);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SampleViewModel sampleViewModel)
        {
            if (ModelState.IsValid)
            {
                Sample createSample = _iMapper.Map<Sample>(sampleViewModel);
                bool isAdd = await _iSampleManager.Create(createSample);

                if (isAdd)
                    return RedirectToAction("Index");
                else
                    ViewBag.ErrorMessage = "Failed to Save Brand";
            }

            return View(sampleViewModel);
        }

        [HttpGet]
        public async Task<ActionResult<SampleViewModel>> Update(int? id)
        {
            if (id == null)
                return NotFound();

            SampleViewModel existSample = _iMapper.Map<SampleViewModel>(await _iSampleManager.GetById(id));

            if (existSample == null)
                return NotFound();

            return View(existSample);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SampleViewModel updateSampleViewModel)
        {
            if (ModelState.IsValid)
            {
                Sample updateSample = _iMapper.Map<Sample>(updateSampleViewModel);
                bool isAdd = await _iSampleManager.Update(updateSample);

                if (isAdd)
                    return RedirectToAction("Index");
                else
                    ViewBag.ErrorMessage = "Failed to Update Sample";
            }

            return View(updateSampleViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int? id)
        {
            if (id == null)
                return NotFound();

            Sample existSample = await _iSampleManager.GetById(id);

            if (existSample == null)
                return NotFound();

            bool remove = await _iSampleManager.Remove(existSample);

            if (remove)
                return RedirectToAction("Index");

            return BadRequest();
        }
    }
}
