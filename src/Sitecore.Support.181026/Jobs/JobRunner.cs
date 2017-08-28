namespace Sitecore.Support.Jobs
{
    using Sitecore.Jobs;
    using Sitecore.Configuration;
    public class JobRunner
    {
        public static void SetPriority(JobArgs args)
        {
            if (args.Job.Options.Method.Method.Name == "PublishWithResult" && args.Job.Options.Category == "publish" && args.Job.Options.SiteName == "publisher")
            {
                args.Job.Options.Priority = Settings.Publishing.ThreadPriority;
            }
            Sitecore.Jobs.JobRunner.SetPriority(args);
        }
    }
}