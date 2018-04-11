using System;

namespace Models
{
    public class UserExperience
    {
        public virtual int TableId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Description { get; set; }
        public virtual int  CountExperience { get; set; }
        public virtual DateTime RegistredDate { get; set; }
    }
}
