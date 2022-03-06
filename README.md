# TinyCLR.Compass
This is compass component for TinyCLR

![Gauge 1](https://storagemurahaje.blob.core.windows.net/github/gauge.jpg)


## How to use

Just add the library to your project and here is the snippet:

```
  GpioPin backlight = GpioController.GetDefault().OpenPin(SC20260.GpioPin.PA15);
            backlight.SetDriveMode(GpioPinDriveMode.Output);
            backlight.Write(GpioPinValue.High);

            var displayController = DisplayController.GetDefault();

            // Enter the proper display configurations
            displayController.SetConfiguration(new ParallelDisplayControllerSettings
            {
                Width = 800,
                Height = 480,
                DataFormat = DisplayDataFormat.Rgb565,
                Orientation = DisplayOrientation.Degrees0, //Rotate display.
                PixelClockRate = 24000000,
                PixelPolarity = false,
                DataEnablePolarity = false,
                DataEnableIsFixed = false,
                HorizontalFrontPorch = 16,
                HorizontalBackPorch = 46,
                HorizontalSyncPulseWidth = 1,
                HorizontalSyncPolarity = false,
                VerticalFrontPorch = 7,
                VerticalBackPorch = 23,
                VerticalSyncPulseWidth = 1,
                VerticalSyncPolarity = false,
            });

            displayController.Enable(); //This line turns on the display I/O and starts
                                        //  refreshing the display. Native displays are
                                        //  continually refreshed automatically after this
                                        //  command is executed.


            var screen = Graphics.FromHdc(displayController.Hdc);

            var compass = new Compass(new CompassSize ( 400, 400));

            Random random = new Random();
            Bitmap bmp;
            var degree = 0;
            while (true)
            {
                compass.Degree = degree;
                bmp = compass.GetBitmap();
                screen.Clear();
                screen.DrawImage(bmp, 0, 0);

                screen.Flush();
                degree+=10;
                if (degree > 360) degree=0;
                Thread.Sleep(1000);
            }
```


Cheers :D.
