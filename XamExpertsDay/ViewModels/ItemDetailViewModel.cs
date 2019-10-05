using System;

using XamExpertsDay.Models;

namespace XamExpertsDay.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Session Item { get; set; }
        public string SpeakerName { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public string EventTitle { get; set; }

        public ItemDetailViewModel(Session session = null)
        {
            Item = session;
            SpeakerName = session.speakers?[0].name;
            Description = session.description;
            Room = session.room;
            EventTitle = session.title;
        }
    }
}
