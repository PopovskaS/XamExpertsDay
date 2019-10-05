using System.Collections.Generic;

namespace XamExpertsDay.Models
{
    public class Agenda
    {
        public object groupId { get; set; }
        public string groupName { get; set; }
        public List<Session> sessions { get; set; }
    }
}
