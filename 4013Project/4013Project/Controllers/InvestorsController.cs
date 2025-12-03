using Microsoft.AspNetCore.Mvc;
using _4013Project.Models;
using System.Collections.Generic;

namespace _4013Project.Controllers
{
    public class InvestorsController : Controller
    {
        public IActionResult Index()
        {
            var investors = new List<Investor>
            {
                new Investor
                {
                    Name = "Jordan Ellis",
                    ImageUrl = "https://media.istockphoto.com/id/2159472620/photo/beautiful-young-business-woman-standing-while-smiling-looking-at-camera-in-the-office.jpg?s=612x612&w=0&k=20&c=IK6UE_xurQ6CVMvIDh96o8YaOM0_oLnn67G02cK5t1A=",
                    Description = "Jordan Ellis is a regional angel investor focused on student-led consumer brands and is an early supporter of OU IBC ventures."
                },
                new Investor
                {
                    Name = "Priya Shah",
                    ImageUrl = "https://images.squarespace-cdn.com/content/v1/61f6d0979fe16f5c0706795d/1718076283447-34FLPT9I2RSUKJAFCT8L/Untitled+design.png?format=2500w",
                    Description = "Priya Shah is a technology entrepreneur who invests in innovative merchandise and mentors teams participating in OU IBC."
                },
                new Investor
                {
                    Name = "Michael Carter",
                    ImageUrl = "https://media.istockphoto.com/id/1413766112/photo/successful-mature-businessman-looking-at-camera-with-confidence.jpg?s=612x612&w=0&k=20&c=NJSugBzNuZqb7DJ8ZgLfYKb3qPr2EJMvKZ21Sj5Sfq4=",
                    Description = "Michael Carter is an OU business alum who provides capital and strategic guidance to multiple OU IBC product lines."
                },
                new Investor
                {
                    Name = "Alicia Nguyen",
                    ImageUrl = "https://plus.unsplash.com/premium_photo-1661688078606-fbadf11e55f6?fm=jpg&q=60&w=3000&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8YXNpYW4lMjBidXNpbmVzcyUyMHdvbWFufGVufDB8fDB8fHww",
                    Description = "Alicia Nguyen specializes in retail and apparel investments and supports OU IBC teams launching new campus gear."
                },
                new Investor
                {
                    Name = "Daniel Rodriguez",
                    ImageUrl = "https://media.istockphoto.com/id/1201437847/photo/good-looking-male-business-professional-in-studio.jpg?s=612x612&w=0&k=20&c=xWZCmQDVE-56daMr_GwppH12xmfW_bANidnq6CT5ExI=",
                    Description = "Daniel Rodriguez is a small-business lender who partners with OU IBC to fund student-run ventures and provide financial coaching."
                },
                new Investor
                {
                    Name = "Sofia Martinez",
                    ImageUrl = "https://t4.ftcdn.net/jpg/04/43/25/95/360_F_443259545_PsPbDmm8HY7JLQU9Ew9DPOdAHtIhMtnD.jpg",
                    Description = "Sofia Martinez is a social-impact investor backing OU IBC products that create value for the OU and Norman communities."
                }
            };

            return View(investors);
        }
    }
}
