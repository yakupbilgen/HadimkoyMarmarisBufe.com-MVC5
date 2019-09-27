using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HadimkoyMarmarisBufe.Controllers
{
	public class SiteController : Controller
	{
		// GET: Site
		/*
		 anasayfa
		 ürünlerimiz
		 menülerimiz
		 hakkımızda
		 neredeyiz?harita
		 iletişim
		 */
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Urunlerimiz()
		{
			return View();
		}

		public ActionResult Menulerimiz()
		{
			return View();
		}

		public ActionResult Hakkimizda()
		{
			return View();
		}

		public ActionResult Neredeyiz()
		{
			return View();
		}

		public ActionResult Iletisim()
		{
			return View();
		}

	}
}