# Events And Delegates
Events and Delegate; its need and usage.

## Events
- Events is a mechanism to communicate between objects
- Used in building <i>Loosly Coupled Application</i>
- Helps extend application

## Delegates
- Delegate is a pointer to a function
- It defines agreement/contract between 2 communicating objects

## How to create a Delegate and Event
- Define a Delegate<br/>
    `delegate void DelegateName(object source, VideoArgs args)`<br/>
    Usually the name of the delegate to be `filename + EventHandler`<br/>
    ```
    public delegate void VideoEncoderEventHandler(object source, VideoArgs args);
    ```
- Define an Event based on that delegate<br/>
    ```
    public event VideoEncoderEventHandler VideoEncoded;
    ```
    Event a better way of defining a delegate and event, clubing both declarations<br/>
    ```
    public event EventHandler<Video> VideoEncoded;
    ```
- Implement Event Handler
    ```
    protected void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
            VideoEncoded(this, new VideoArgs(video));
    }
    ```
- Implement the subscriber contract
    ```
    public void SendEmail(object source, VideoArgs args)
    {
        System.Console.WriteLine($"Email sent for album {args.Album.Name}");
    }
    ```
    Signature to be the same as the Delegate
- Register the subcribers
    ```
    videoFormatter.VideoEncoded += new EmailService().SendEmail;
    videoFormatter.VideoEncoded += new MessageService().SendText;
    ```
- Raise the Event <br/>
    `OnVideoEncoded(video);`

## Types of Delegate Expressions
- Lambda Expression<br/>
    ```
    AreaCalculator areaOfCircleCalculater = (r) => 3.14 * r * r;
    double area = areaOfCircleCalculater(20);
    ```
- Func delegate<br/>
    ```
    Func<int, double> areaOfCircleFunc = (r) => 3.14 * r * r;
    double areaFunc = areaOfCircleFunc.Invoke(20);
    ```
    Takes in parameters, input(s) and output<br/>
    `Func<in, in, out> delegatename = (in, in) => return out`
- Action delegate<br/>
    ```
    Func<int, double> areaOfCircleFunc = (r) => 3.14 * r * r;
    double areaFunc = areaOfCircleFunc.Invoke(20);
    ```
    Takes in input parameters only<br/>
    `Action<in> delegatename = (in) => perform actions`
- Predicate delegate
    ```
    Predicate<int> isAreaGreaterThanRadius = (r) => r > (3.14 * r * r);
    bool isAreaGreater = isAreaGreaterThanRadius.Invoke(20);
    ```
    Takes in input parameters and retuns boolean value
    `Predicate<in> isCondition = (in) => returns boolen value`