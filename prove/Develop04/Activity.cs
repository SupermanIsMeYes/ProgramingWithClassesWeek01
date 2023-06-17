class Activity
{
    private bool animate = true;

    //private string stringForBegining = "";

    public void StartCounter(int waitTimeInSeconds)
    {

        // Delay for the specified time
        Thread.Sleep(waitTimeInSeconds * 1000);
    }

    public void StartAnimation(string stringForBegining)
    {
        char[] spinnerFrames = { '|', '/', '-', '\\' };
        int currentFrameIndex = 0;

        // Keep updating the animation until instructed to stop
        while (animate)
        {
            // Clear the console and display the current frame of the animation
            Console.Clear();
            Console.Write(stringForBegining+spinnerFrames[currentFrameIndex]);

            // Wait for the specified delay
            Thread.Sleep(100);

            // Update the frame index for the next iteration
            currentFrameIndex = (currentFrameIndex + 1) % spinnerFrames.Length;
        }
    }

    public void StopAnimation()
    {
        animate = false;
    }
}