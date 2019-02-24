using System;

namespace Domain
{
    public class Episode: IEntity
    {
        public String ShowName
        {
            get; set;
        }

        public int Number
        {
            get;
            set;
        }

        public int Season
        {
            get;
            set;
        }

        public Subtitle Sub
        {
            get;
            set;
        }
        public Guid guid { get; set; }
    }

    public class Subtitle
    {
        public Subtitle()
        {
        }

        public String Language
        {
            get;
            set;
        }

        public String EpisodeName
        {
            get;
            set;
        }

        public Uri FileURL
        {
            get;
            set;
        }
    }
}
