using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEFProject.Models
{
    public class SkillsTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SkillName { get; set; }
        public string SkillDescription { set; get; }
        public override string ToString()
        {
            return ("SkillName: " + SkillName +
                "\nSkillDescription: " + SkillDescription);
        }
    }
}
