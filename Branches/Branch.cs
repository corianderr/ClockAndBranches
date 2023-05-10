namespace Branches;

public class Branch
{
    public List<Branch> Branches { get; }

    public Branch()
    {
        Branches = new List<Branch>();
    }

    public void AddBranch(Branch branch)
    {
        Branches.Add(branch);
    }
}