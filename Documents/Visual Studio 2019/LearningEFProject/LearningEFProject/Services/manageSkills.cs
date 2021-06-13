using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningEFProject.Models;

namespace LearningEFProject.Services
{
    public class manageSkills
    {
        SampleContext context;
        public manageSkills()
        {
            context = new SampleContext();
        }
        public bool AddSkills(SkillsTable sk)
        {
            context.skills.Add(sk);
            context.SaveChanges();
            return true;
        }
        public SkillsTable GetSkills(string skillName)
        {
            SkillsTable mysk = context.skills.Where(s => s.SkillName == skillName).FirstOrDefault();
            return mysk;
        }
        public bool EditSkills(string skillName,SkillsTable sk)
        {
            SkillsTable mysk = GetSkills(sk.SkillName);
            if (mysk !=null)
            {
                sk.SkillName = mysk.SkillName;
                sk.SkillDescription = mysk.SkillDescription;
                context.SaveChanges();
                return true;

            }
            return false;
        }
        public bool DeleteSkills(string skillName)
        {
            SkillsTable myskT = GetSkills(skillName);
            context.skills.Remove(myskT);
            context.SaveChanges();
            return true;

        }
        public List<SkillsTable> GetAllSkills()
        {
            return context.skills.ToList();
        }
    }
}
