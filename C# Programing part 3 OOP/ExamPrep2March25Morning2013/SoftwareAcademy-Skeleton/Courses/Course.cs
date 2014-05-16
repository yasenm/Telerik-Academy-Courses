using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Course : ICourse
{
    public string Name { get; set; }

    public ITeacher Teacher { get; set; }

    public IList<string> Topics = new List<string>();

    public void AddTopic(string topic)
    {
        this.Topics.Add(topic);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType() + ": ");
        result.Append(String.Format("Name={0};", this.Name));
        if (this.Teacher != null)
        {
            result.Append(String.Format("Teacher={0};", this.Teacher.Name));
        }

        if (this.Topics.Count > 0)
        {
            result.Append(" Topics=[");
            for (int i = 0; i < Topics.Count; i++)
            {
                result.Append(Topics[i] + ", ");
            }
            result.Length = result.Length - 2;
            result.Append("];");
        }

        return result.ToString();
    }
}
