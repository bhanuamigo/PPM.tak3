using Program.Model.modl;
namespace PROGRAM.DOMINE.domine
{
public class Projectdata
{
    public List<Project> Prolifics = new List<Project>();

    //Method for adding projects
    public void Addproject(Project project)
    {
        Prolifics.Add(project);
    }
    public void viewProject(Project project)
    {
        Console.WriteLine(" Name of the  Project - " + project.ProjectName + "\n Project Id - " + project.id + "\n Start date of Project - " + project.Startdate + "\n deadline date of Project - " + project.Enddate);
        Console.WriteLine("");
    }
     public void display()
    {
            for (int j = 0; j < Prolifics.Count; j++)
            {
                if(Prolifics[j].AddingEmplist.Count == 0){
                    Console.WriteLine("No employee in the project");
                }
                else{
                    Console.WriteLine("Project Name - " + Prolifics[j].ProjectName);
                    Console.WriteLine("Names of the employees in the project :");
                for (int i = 0; i < Prolifics[j].AddingEmplist.Count; i++)
                {
                    Console.WriteLine(Prolifics[j].AddingEmplist[i].firstName);
                }
            }}
    }

    

    public void emptopro(int pid,Employee ename){
        for(int i=0; i<Prolifics.Count;i++){
            if(Prolifics[i].id==pid){
                Prolifics[i].AddingEmplist.Add(ename);
            }
        }
    }

     public void empfrompro(int pid,Employee ename){
        for(int i=0; i<Prolifics.Count;i++){
            if(Prolifics[i].id==pid){
                Prolifics[i].AddingEmplist.Remove(ename);
            }
        }
    }


    public Boolean exist(int pid){
        for(int i=0; i<Prolifics.Count;i++){
            if(pid== Prolifics[i].id){
                return true;
            }
        }
        return false;
    }

    public void viewAllProjects()
    {
        foreach (var p in Prolifics)
        {
            viewProject(p);
        }
    }

    //Method to view all projects
    public void ShowProject(int eid)
    {
        foreach (Project p in Prolifics)
        {

            if (p.id == eid)
            {
                Console.WriteLine(" Name of the project - " + p.ProjectName + "\n Project Id - " + p.id + "\n Start  date of project - " + p.Startdate + "\n deadline  of the Project - " + p.Enddate);
            }
            else
            {
                Console.WriteLine("Invalid ID re-enter valid ID");
            }
        }
    }

    public void SearchProject(string search)
    {
        var match = Prolifics.Where(c => c.ProjectName.Contains(search));
        foreach (var e in match)
        {
            Console.WriteLine("");
            Console.WriteLine(" Name of the project - " + e.ProjectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.Startdate + "\n Deadline  of project - " + e.Enddate);
        }
    }

    public void Display()
    {
        
            for (int j = 0; j < Prolifics.Count; j++)
            {
                if(Prolifics[j].AddingEmplist.Count == 0){
                    Console.WriteLine("No employee in the project");
                }
                else{
                    Console.WriteLine("Project Name - " + Prolifics[j].ProjectName);
                    Console.WriteLine("Names of the employees in the project :");
                for (int i = 0; i < Prolifics[j].AddingEmplist.Count; i++)
                {
                    Console.WriteLine(Prolifics[j].AddingEmplist[i].firstName);
                }
            }}
    }
}
public class EmpManagement
{
    public List<Employee> empList = new List<Employee>();

    //Method for adding new employee
    public void AddEmp(Employee emp)
    {
        empList.Add(emp);
    }


    public void displayEmp(Employee emp)
    {
        Console.WriteLine(" Employee Id - " + emp.EmployeeID + "\n Employee first name - " + emp.firstName + "\n Employee last name - " + emp.lastName + "\n Employee email id - " + emp.email + "\n Employee mobile number - " + emp.mobile + "\n Employee address - " + emp.address + "\n Role Id - " + emp.roleid + "\n Role Name - " + emp.roleName);
        Console.WriteLine("");
        Console.WriteLine("");
    }

    //Method for viewing all employees
    public void ShowEmp()
    {
        foreach (var j in empList)
        {
            displayEmp(j);
        }
    }

    public void ShowEmployee(int eid)
    {
        foreach (Employee j in empList)
        {

            if (j.EmployeeID == eid)
            {
                Console.WriteLine(" Name of the Employee - " + j.firstName + " " + j.lastName + "\n Employee Id - " + j.EmployeeID);
            }
            else
            {
                Console.WriteLine("Invaild ID re-entre the vaild ID");
            }
        }
    }

    public Boolean exist(int eid){
        for(int i=0; i<empList.Count;i++){
            if(eid== empList[i].EmployeeID){
                return true;
            }
        }
        return false;
    }

    public Employee eDetails(int eid){
        Employee emp = new Employee();
        for(int i=0;i<empList.Count;i++){
            if(eid==empList[i].EmployeeID){
               emp=empList[i];
                return emp;
            }
        }
        return emp;
    }
}
}

public class RoleManagement
{


    public List<Role> RoleList = new List<Role>();



    //Method for adding roles
    public void RoleAdd(Role role)
    {
        RoleList.Add(role);
    }

    //Method for viewing all roles
    public void displayRole()
    {
        foreach (var e in RoleList)
        {
            Console.WriteLine(" Name of the Role - " + e.RoleName + "\n Role Id - " + e.RoleId);
            Console.WriteLine();
        }
    }

}


// public class AddingEmpProject
// {
//     public List<AddEmpProject> AddingEmplist = new List<AddEmpProject>();

//     public void addingemp(AddEmpProject add)
//     {
//         AddingEmplist.Add(add);
//     }
    
//     public void displayingemp()
//     {
//         foreach (var e in AddingEmplist)
//         {
//             Console.WriteLine(e.ProjectName);
//         }
//     }
// }
// }
