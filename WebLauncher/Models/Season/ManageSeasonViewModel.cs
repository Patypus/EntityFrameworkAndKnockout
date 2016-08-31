using System.Collections.Generic;

namespace EntityFrameworkAndKnockout.Models.Season
{
    public class ManageSeasonViewModel
    {
        public List<int> YearsWithNoCreatedSeasons { get; set; }

        public List<int> EditableSeasons { get; set; }
    }
}