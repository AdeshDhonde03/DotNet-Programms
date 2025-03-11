using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using poultry_management_system.web.Data;
using poultry_management_system.web.Models.Domain;

using poultry_management_system.web.Models.ViewModels;

namespace poultry_management_system.web.Controllers
{
    public class DailyEntryController : Controller
    {
        PoultryDbContext _poultryDbContext;
        public DailyEntryController(PoultryDbContext poultryDbContext)
        {
            _poultryDbContext = poultryDbContext;
        }
        [HttpGet]
        public IActionResult Add_Entry()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add_Entry")]
        public IActionResult Add_Entry(AddDailyEntry addDailyEntry)
        {
            addDailyEntry.Closing_Birds = addDailyEntry.Opening_Birds - addDailyEntry.Mortallity;
            DialyFlockEntry dialyFlockEntry = new DialyFlockEntry
            {
                Age = addDailyEntry.Age,
                Opening_Birds = addDailyEntry.Opening_Birds,
                Mortallity = addDailyEntry.Mortallity,
                Closing_Birds=addDailyEntry.Closing_Birds,
                Feed_Consume= addDailyEntry.Feed_Consume,
                Avg_Weight=addDailyEntry.Avg_Weight,
                Daily_Eggs_Production=addDailyEntry.Daily_Eggs_Production,
                Health_Status=addDailyEntry.Health_Status,
                Instruction=addDailyEntry.Instruction
            };
            _poultryDbContext.DailyEntry.Add(dialyFlockEntry);
            _poultryDbContext.SaveChanges();

            return RedirectToAction("List");

        }
        [HttpGet]
        public IActionResult List()
        {
            var records = _poultryDbContext.DailyEntry.ToList();
            return View(records);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var entry = _poultryDbContext.DailyEntry.FirstOrDefault(x => x.Id == id);
            if (entry != null)
            {
                EditEntry edit = new EditEntry
                {
                    Age = entry.Age,
                    Opening_Birds = entry.Opening_Birds,
                    Mortallity = entry.Mortallity,
                    Closing_Birds = entry.Closing_Birds,
                    Feed_Consume = entry.Feed_Consume,
                    Avg_Weight = entry.Avg_Weight,
                    Daily_Eggs_Production = entry.Daily_Eggs_Production,
                    Health_Status = entry.Health_Status,
                    Instruction = entry.Instruction
                };

                return View(edit);
            }
            return View(null);
            
            
        }
        [HttpPost]
        [ActionName("Edit")]
        public IActionResult Edit(EditEntry editEntry)
        {
            var entry = new DialyFlockEntry
            {
                Age = editEntry.Age,
                Opening_Birds = editEntry.Opening_Birds,
                Mortallity = editEntry.Mortallity,
                Closing_Birds = editEntry.Closing_Birds,
                Feed_Consume = editEntry.Feed_Consume,
                Avg_Weight = editEntry.Avg_Weight,
                Daily_Eggs_Production = editEntry.Daily_Eggs_Production,
                Health_Status = editEntry.Health_Status,
                Instruction = editEntry.Instruction
            };
            var ExistingEntry = _poultryDbContext.DailyEntry.Find(editEntry.Id);
            if (ExistingEntry != null)
            {
                ExistingEntry.Age = entry.Age;
                ExistingEntry.Opening_Birds = entry.Opening_Birds;
                ExistingEntry.Mortallity = entry.Mortallity;
                ExistingEntry.Closing_Birds = entry.Closing_Birds;
                ExistingEntry.Feed_Consume = entry.Feed_Consume;
                ExistingEntry.Avg_Weight = entry.Avg_Weight;
                ExistingEntry.Daily_Eggs_Production = entry.Daily_Eggs_Production;
                ExistingEntry.Health_Status = entry.Health_Status;
                ExistingEntry.Instruction = entry.Instruction;
                _poultryDbContext.SaveChanges();
                return RedirectToAction("List");

            }


            return RedirectToAction("Edit", new { id = editEntry.Id });
        }
        [HttpGet]
        
        public IActionResult Delete(Guid id)
        {
            var entry = _poultryDbContext.DailyEntry.Find(id);
            if (entry != null)
            {
                _poultryDbContext.DailyEntry.Remove(entry);
                _poultryDbContext.SaveChanges();
                return RedirectToAction("List");
            }
            return RedirectToAction("List");
        }

    }
}
