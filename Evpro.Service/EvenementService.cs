using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using Evpro.Data.Infrastructure;
using Evpro.Domain;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Evpro.Service
{
    public class EvenementService : MyServiceGeneric<ourevent>, IEvenementService
    {
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);

        public EvenementService() : base(utw)
        {

        }

       
        public ourevent getclosestevent()
        {
            IEvenementService es = new EvenementService();
            var e = es.GetMany();
            DateTime? d = new DateTime(2050, 08, 14);
            DateTime? f = DateTime.Today;
            ourevent eve = new ourevent();
            foreach (var item in e)
            {
                if (item.eventStartingDate < d && item.eventStartingDate > f)
                {
                    eve.idEvent = item.idEvent;
                    eve.name = item.name;
                    eve.category = item.category;
                    eve.cityAdress = item.cityAdress;
                    eve.countryAdress = item.countryAdress;
                    eve.eventFinishingDate = item.eventFinishingDate;
                    eve.eventStartingDate = item.eventStartingDate;
                    eve.description = item.description;
                    eve.eventType = item.eventType;
                    eve.facebookEventLink = item.facebookEventLink;
                    eve.image = item.image;
                    eve.laltitude = item.laltitude;
                    eve.longitude = item.longitude;
                    eve.price = item.price;
                    eve.slogan = item.slogan;
                    eve.tag = item.tag;
                    eve.twitterEventLink = item.twitterEventLink;
                    eve.video = item.video;
                    d = item.eventStartingDate;
                }
            }
            return (eve);
        }

        public ourevent getlastdoneevent()
        {
            IEvenementService es = new EvenementService();
            var e = es.GetMany();
            DateTime? d = new DateTime(2000, 08, 14);
            DateTime? f = DateTime.Today;
            int id = 0;
            ourevent eve = new ourevent();
            foreach (var item in e)
            {
                if (item.eventFinishingDate > d && item.eventStartingDate < f)
                {
                    eve.idEvent = item.idEvent;
                    eve.name = item.name;
                    eve.category = item.category;
                    eve.cityAdress = item.cityAdress;
                    eve.countryAdress = item.countryAdress;
                    eve.eventFinishingDate = item.eventFinishingDate;
                    eve.eventStartingDate = item.eventStartingDate;
                    eve.description = item.description;
                    eve.eventType = item.eventType;
                    eve.facebookEventLink = item.facebookEventLink;
                    eve.image = item.image;
                    eve.laltitude = item.laltitude;
                    eve.longitude = item.longitude;
                    eve.price = item.price;
                    eve.slogan = item.slogan;
                    eve.tag = item.tag;
                    eve.twitterEventLink = item.twitterEventLink;
                    eve.video = item.video;
                    d = item.eventStartingDate;
                }
            }
            return (eve);
        }
        public FileStreamResult generatepdf(List<ourevent> e1)
        {

            
            WebGrid grid = new WebGrid(source: e1, canPage: false, canSort: false);
            string gridHtml = grid.GetHtml(
                columns: grid.Columns(
                            grid.Column("name", "name"),
                            grid.Column("category", "category"),
                            grid.Column("cityAdress", "cityAdress"),
                            grid.Column("countryAdress", "countryAdress"),
                            grid.Column("eventFinishingDate", "eventFinishingDate"),
                            grid.Column("eventStartingDate", "eventStartingDate"),
                            grid.Column("laltitude", "laltitude"),
                            grid.Column("longitude", "longitude"),
                            grid.Column("price", "price"),
                            grid.Column("slogan", "slogan"),
                            grid.Column("tag", "tag")
                        )
                    ).ToString();

            string exportData = String.Format("<html><head>{0}aa</head><body>{1}</body></html>", "<style>table{ border-spacing: 10px; border-collapse: separate; border: 1px solid red;}</style>", gridHtml);
            var bytes = System.Text.Encoding.UTF8.GetBytes(exportData);
            using (var input = new MemoryStream(bytes))
            {
                var output = new MemoryStream();
                var document = new iTextSharp.text.Document(PageSize.A2, 50, 50, 50, 50);
                var writer = PdfWriter.GetInstance(document, output);
                writer.CloseStream = false;
                document.Open();

                var xmlWorker = iTextSharp.tool.xml.XMLWorkerHelper.GetInstance();
                xmlWorker.ParseXHtml(writer, document, input, System.Text.Encoding.UTF8);
                document.Close();
                output.Position = 0;
                return new FileStreamResult(output, "application/pdf");
            }

        }

    }
}
