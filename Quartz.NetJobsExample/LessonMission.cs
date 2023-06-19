namespace Quartz.NetJobsExample;

public class LessonMission : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        JobDataMap data = context.JobDetail.JobDataMap;
        
        Console.WriteLine($"{data.GetString("name")} {data.GetString("Surname")} is punishable....");
        
        return Task.CompletedTask;
    }
}