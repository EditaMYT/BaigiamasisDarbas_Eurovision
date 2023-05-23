using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Eurovision
{
    internal class LatestNews
    {
        [Test]
        public void StorySwedensLoreenWinsEurovisionSongContest()
        {
            Driver.InitializeDriver();
            

            
            Assert.AreEqual(expectedResult, actualResult);
            
            Driver.ShutdownDriver();
        }
    }
}
