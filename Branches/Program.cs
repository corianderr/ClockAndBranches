using Branches;

var branch1 = new Branch();
var branch2 = new Branch();
var branch3 = new Branch();
var branch4 = new Branch();
var branch5 = new Branch();
var branch6 = new Branch();
var branch7 = new Branch();

branch1.AddBranch(branch2);
branch1.AddBranch(branch7);

branch7.AddBranch(new Branch());

branch2.AddBranch(branch3);
branch2.AddBranch(branch6);
branch2.AddBranch(new Branch());

branch6.AddBranch(new Branch());

branch3.AddBranch(branch4);
branch3.AddBranch(new Branch());

branch4.AddBranch(branch5);
branch1.AddBranch(new Branch());

Console.WriteLine($"The depth of provided structure is: {GetDepthCount(branch1)}");
Console.WriteLine($"The depth of provided structure is: {GetDepthCount(branch2)}");
Console.WriteLine($"The depth of provided structure is: {GetDepthCount(branch3)}");
Console.WriteLine($"The depth of provided structure is: {GetDepthCount(branch4)}");
Console.WriteLine($"The depth of provided structure is: {GetDepthCount(branch5)}");
Console.WriteLine($"The depth of provided structure is: {GetDepthCount(branch6)}");


int GetDepthCount(Branch branch)
{
    if (branch.Branches.Count == 0)
        return 1;

    int maxChildDepth = 0;
    foreach (var b in branch.Branches)
    {
        var childDepthCount = GetDepthCount(b);
        if (maxChildDepth < childDepthCount)
            maxChildDepth = childDepthCount;
    }

    return 1 + maxChildDepth;
}