using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox1.Models
{
    public class SuggestionModel
    {
        private string topic;
        private string suggestion;
        private string userName;

        [Key]
        public int RecordNum { get; set; }

        public string Topic
        {
            get { return this.topic; }
            set { this.topic = value; }
        }

        public string Suggestion
        {
            get { return this.suggestion; }
            set { this.suggestion = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
    }
}