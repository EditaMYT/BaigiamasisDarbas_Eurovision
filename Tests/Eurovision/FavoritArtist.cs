using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Eurovision
{
    internal class FavoritArtist
    {
        [Test]
        public void ThirdOption()
        {
            Driver.InitializeDriver();

            Event.Open();
            Event.ClickTheShows();
            Event.ClickParticipants();
            Event.ClickThirdOption();

            Driver.ShutdownDriver();
        }
    }
}
