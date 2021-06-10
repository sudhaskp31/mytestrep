using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample
{
    public class Skill
    {
        public string SkillName { get; set; }
        public string Skill_description { get; set; }
        public override string ToString()
        {
            return "Skill Name: " + SkillName +
                "\nSkill Description " + Skill_description;
        }
    }
}
