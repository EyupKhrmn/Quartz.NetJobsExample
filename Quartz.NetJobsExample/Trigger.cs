using Quartz.Impl;

namespace Quartz.NetJobsExample;

public class Trigger
{
    private Task<IScheduler> Start()
    {
        ISchedulerFactory factory = new StdSchedulerFactory();

        Task<IScheduler> sched = factory.GetScheduler();

        if (!sched.IsCompleted)
            sched.Start();

        return sched;
    }

    public Student Student { get; set; }

    public void LessonTrigger()
    {
        Task<IScheduler> sched = Start();

        IJobDetail lessonMission = JobBuilder.Create<LessonMission>().WithIdentity("LessonMission", null)
            .UsingJobData("Name", Student.Name).UsingJobData("Surname", Student.Surname).Build();

        ISimpleTrigger triggerLessonMission = (ISimpleTrigger)TriggerBuilder.Create().WithIdentity("LessonMission").StartAt(DateTime.UtcNow).WithSimpleSchedule(x => x.WithIntervalInSeconds(15).WithRepeatCount(1)).Build();
        
        sched.Result.ScheduleJob(lessonMission, triggerLessonMission);
    }
}