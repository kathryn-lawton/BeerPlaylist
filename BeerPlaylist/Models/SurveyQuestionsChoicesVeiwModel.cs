using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
    public class SurveyQuestionsChoicesVeiwModel
    {
        public Survey Survey { get; set; }
        public Questions Questions { get; set; }
        public Choices Choices { get; set; }
    }
}