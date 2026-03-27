using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLinqProgramOne
{
    public partial class LinqDemo : System.Web.UI.Page

    {
        // Step 2: Mapping Data Model to Object Model
        public class Student
        {
            public int Rno { get; set; }
            public string Name { get; set; }
            public string Course { get; set; }
        }

        // Sample data (LINQ to Objects)
        List<Student> students = new List<Student>
    {
        new Student { Rno = 1, Name = "Amit", Course = "Java" },
        new Student { Rno = 2, Name = "Neha", Course = "Python" },
        new Student { Rno = 3, Name = "Ravi", Course = "Java" },
        new Student { Rno = 4, Name = "Sara", Course = "C#" }
    };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            string courseName = txtCourse.Text;

            // Step 3a: Query Syntax
            var querySyntaxResult = from s in students
                                    where s.Course.Equals(courseName, StringComparison.OrdinalIgnoreCase)
                                    select s;

            gvQuerySyntax.DataSource = querySyntaxResult.ToList();
            gvQuerySyntax.DataBind();

            // Step 3b: Method Syntax
            var methodSyntaxResult = students
                                     .Where(s => s.Course.Equals(courseName, StringComparison.OrdinalIgnoreCase))
                                     .ToList();

            gvMethodSyntax.DataSource = methodSyntaxResult;
            gvMethodSyntax.DataBind();
        }
    }
    }
