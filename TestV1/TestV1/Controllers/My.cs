using Microsoft.AspNetCore.Mvc;
using TestV1.Models;
using TestV1.VM;

namespace TestV1.Controllers
{
    public class My : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        public My(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        TestV1DB db = new TestV1DB();
        [HttpGet]
        public IActionResult Single(int? id)
        {
            VmSale oSale = null;
            var oSM = db.studentMasters.Where(x => x.SID == id).FirstOrDefault();
            if (oSM != null)
            {
                oSale = new VmSale();
                oSale.SID=oSM.SID;
                oSale.SName = oSM.SName;
                oSale.SAge = oSM.SAge;
                oSale.SDate = oSM.SDate;
                oSale.SPhoto = oSM.SPhoto;
                var listd = new List<VmSale.VmDetail>();
                var listSD = db.bookDetails.Where(x => x.SID == id).ToList();
                foreach (var oSD in listSD)
                {
                    var oDet = new VmSale.VmDetail();
                    oDet.BID = oSD.BID;
                    oDet.Title = oSD.Title;
                    oDet.Price = oSD.Price;
                    listd.Add(oDet);
                }
                oSale.Details = listd;
            }
            oSale = oSale == null ? new VmSale() : oSale;
            ViewData["List"] = db.studentMasters.ToList();
            return View(oSale);
        }
        [HttpPost]
        public async Task<IActionResult> Single(VmSale model,IFormFile img)
        {
            var filename = img.FileName;
            var filepath = Path.Combine(_hostingEnvironment.WebRootPath,"Pic", filename);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                await img.CopyToAsync(stream);
            }
            var oSMaster = db.studentMasters.Find(model.SID);
            if (oSMaster == null)
            {
                oSMaster = new StudentMaster();
                oSMaster.SName = model.SName;
                oSMaster.SAge = model.SAge;
                oSMaster.SDate = model.SDate;
                oSMaster.SPhoto = "/Pic/" + filename;
                db.studentMasters.Add(oSMaster);
                ViewBag.Message = "O";
                var listD = new List<BookDetail>();
                if (model.Title != null && model.Title.Length > 0)
                {
                    for (int i = 0; i < model.Title.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(model.Title[i]))
                        {
                            var oDet = new BookDetail();
                            oDet.SID = oSMaster.SID;
                            oDet.Title = model.Title[i];
                            oDet.Price = model.Price[i];
                            listD.Add(oDet);
                        }


                    }
                }
               
                db.studentMasters.Add(oSMaster);
                db.bookDetails.AddRange(listD);
                db.SaveChanges();
            }
            else
            {
                oSMaster.SName = model.SName;
                oSMaster.SAge = model.SAge;
                oSMaster.SDate = model.SDate;
                oSMaster.SPhoto = (filename != null) ? "/Pic/" + filename : oSMaster.SPhoto;
                ViewBag.Message = "u";
                var drem = db.bookDetails.Where(x => x.SID == model.SID).ToList();
                var mrem = db.studentMasters.Find(model.SID);
                db.bookDetails.RemoveRange(drem);
                db.studentMasters.Remove(mrem);
                db.SaveChanges();
                var listD = new List<BookDetail>();
                for (int i = 0; i < model.Title.Length; i++)
                {
                    if (!string.IsNullOrEmpty(model.Title[i]))
                    {
                        var oDet = new BookDetail();
                        oDet.SID = oSMaster.SID;
                        oDet.Title = model.Title[i];
                        oDet.Price = model.Price[i];
                        listD.Add(oDet);
                    }


                }
                db.studentMasters.Add(oSMaster);
                db.bookDetails.AddRange(listD);
                db.SaveChanges();
            }
            return RedirectToAction("Single");
        }
        [HttpGet]
        public ActionResult SingleDelete(int id)
        {
            var SD = (from o in db.bookDetails where o.SID == id select o).ToList();
            var ms = (from o in db.studentMasters where o.SID == id select o).FirstOrDefault();
            if (SD != null) db.bookDetails.RemoveRange(SD);
            db.studentMasters.Remove(ms);
            db.SaveChanges();
            return RedirectToAction("Single");
        }
    }
}
