using System;
using System.Collections.Generic;

namespace Eventador
{
    public class Session : AggregateRoot
    {
        public static Session Create(Guid id, string title, string presenter, DateTimeOffset startsAt, TimeSpan duration)
        {
            return new Session 
            {
                Id = id,
                Title = title,
                Presenter = presenter,
                StartsAt = startsAt,
                Duration = duration    
            };
        }

        public string Title { get; private set; }

        public string Presenter { get; private set; }

        public DateTimeOffset StartsAt { get; private set; }

        public TimeSpan Duration { get; private set; }

        public bool IsCatered { get; private set; }

        public ICollection<Attendee> Attendees { get; } = new List<Attendee>();
    }
}