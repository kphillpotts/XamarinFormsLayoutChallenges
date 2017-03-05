# Social Network App Layout Design in Xamarin.Forms

Xamarin.Forms is a crazy productive framework for building cross platform apps. However, straight out of the box you might find your User Interfaces are a bit bland. A good understanding of the layout system (and a good graphic designer) are really going to help you make your UI's awesome. (or at least not suck)

So let's see how to recreate a simple Social Network profile type page in Xamarin.Forms. 

 There are two challenge ingredients for this app.

1) Creating a curved header Image

2) Making a Profile Image that overlaps the header

Th design of the app looks a little like this:

![Design](https://raw.githubusercontent.com/kphillpotts/XamarinFormsLayoutChallenges/master/SocialNetwork/Screenshots/iPhone6-33.png)

## Basic Layout
Grids are my default goto layout container for Xamarin.Forms.  They aren't perfect for every situation, but they do provide:

* Proportional sizing of rows and columns, 
* The ability to overlaying controls within a cell (or multiple cells), and 
* They resize reasonably well by default

All of which make them pretty useful for a range of designs.

The basic structure of the page is a simple Grid with one column and multiple rows.  Within the cells are stack layouts for some of the text elements that stack on each other, and to provide the three social stats across the page it has a nested grid with three columns.

Using Xamarin Inspector is a pretty good way of visualising at the View Hierarchy.

![Xamarin Inspector](https://raw.githubusercontent.com/kphillpotts/XamarinFormsLayoutChallenges/master/SocialNetwork/Screenshots/Inspector.png)

## Let's break it down

### Header
The header is just basically an Image that is fills the first row of the Grid.  To get the curve at the bottom you have a couple of options.

#### Option 1: Pre-made Image
You could create your header image with a curve at the bottom like this:

![Header Image](https://github.com/kphillpotts/XamarinFormsLayoutChallenges/blob/master/SocialNetwork/Screenshots/HeaderCurved.png)


The downside of this is that you have to prepare this ahead of time, and may not be appropriate for dynamically loaded images.

#### Option 2: Apply a mask
Instead we can kind of cheat and just add a mask image that lays over the background image at the bottom.  This is the option I went for here because it provides more flexibility.  We could for example, have different masks for different OS's or different Idioms (eg. Phone, Tablet, Desktop).  The mask image could be any design you want, but for this I just went for a simple arc, like this (shadow added so you can see the shape).

![Curved Image Mask](https://raw.githubusercontent.com/kphillpotts/XamarinFormsLayoutChallenges/master/SocialNetwork/Screenshots/CurvedMask-sample.png)

```xml
<!-- header background -->
<Image Source="HeaderBackground.png" Aspect="AspectFill"/>
<Image Source="CurvedMask.png" VerticalOptions="End" Aspect="AspectFill" Margin="0,0,0,-1"/>
```
It provides a nice effect and the only real downside is that it has to be the same colour as the background.  You'll may notice that there is something slightly hacky in there and that is setting the `Margin` bottom to -1.  This is just to cover off some weirdness you might get on some different sizes where the background shows undrneath.  So putting the value to -1 just means it will handle that boundry condition.

### Profile Image
The profile image is just a simple graphic, but the trick to get it to overlay the background image is with just a couple of settings.

```xml
<Image Source="ProfilePic.png" Margin="0,0,0,-50" HeightRequest="100" WidthRequest="100" HorizontalOptions="Center" VerticalOptions="End"/>
```

* Set the `WidthRequest` and `HeightRequest` to a known value (100 in this case)
* Set the `Margin` to a negative value so that it comes up the page by half of it's height (50).

And that's it.  

Now I did kind of cheat because I've got a precreated image for this sample, but that's because I just wanted to talk about layout.  In a real app, I highly recommend you use the [ImageCirclePlugin](https://github.com/jamesmontemagno/ImageCirclePlugin) from James Montemagno, or use the [FFImageLoading](https://github.com/luberda-molinet/FFImageLoading) Library and apply a [CircleTransformation](https://github.com/luberda-molinet/FFImageLoading/wiki/Transformations-Guide#circletransformation) to the image.

### ScrollView
I've wrapped the main grid with a ScrollView, this is just so if the page ends up being larger than the screen then you can scroll down to the bottom.  

Also there is a ScrollView around the Profile Description. Generally speaking having one ScrollView within another is a no-no, but in this case it's not really a deal breaker because it is just there to handle the case where the profile description is just a little bit longer and pushes the button off the bottom of the page.

## How does it scale?
The true test of any page is how does it scale across different sizes, and actually it does pretty well.  That's the magic of grids.

![alt](https://github.com/kphillpotts/XamarinFormsLayoutChallenges/blob/master/SocialNetwork/Screenshots/iPhone6Plus-33.png?raw=true)
![alt](https://github.com/kphillpotts/XamarinFormsLayoutChallenges/blob/master/SocialNetwork/Screenshots/iPhone6-33.png?raw=true)
![alt](https://github.com/kphillpotts/XamarinFormsLayoutChallenges/blob/master/SocialNetwork/Screenshots/iPhone5-33.png?raw=true)

## Show me the codez
```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:SocialNetwork"
             x:Class="SocialNetwork.MainPage"
            BackgroundColor="White">

    <ScrollView>
        <Grid ColumnSpacing="0" RowSpacing="0">
            <Grid.RowDefinitions>
                <RowDefinition Height="AUTO" />
                <RowDefinition Height="AUTO" />
                <RowDefinition Height="AUTO" />
                <RowDefinition Height="*" />
                <RowDefinition Height="AUTO" />
            </Grid.RowDefinitions>

            <!-- header background -->
            <Image Source="HeaderBackground.png" Aspect="AspectFill"/>
            <Image Source="CurvedMask.png" VerticalOptions="End" Aspect="AspectFill" Margin="0,0,0,-1"/>

            <!-- profile image -->
            <Image Source="ProfilePic.png" Margin="0,0,0,-50" HeightRequest="100" WidthRequest="100" HorizontalOptions="Center" VerticalOptions="End"/>

            <!-- Profile Name -->
            <StackLayout Grid.Row="1" HorizontalOptions="Center" Padding="0,50,0,00">
                <Label HorizontalTextAlignment="Center" Text="Clementine" Style="{StaticResource ProfileNameLabel}"/>
                <Label HorizontalTextAlignment="Center" Text="Hipster Coffee Drinker" Margin="0,-5" Style="{StaticResource ProfileTagLabel}"/>
            </StackLayout>

            <!-- Social Stats Section -->
            <Grid Grid.Row="2" ColumnSpacing="0" RowSpacing="0" Margin="0,30">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="*" />
                </Grid.ColumnDefinitions>

                <StackLayout>
                    <Label Text="33" Style="{StaticResource StatsNumberLabel}"/>
                    <Label Text="Likes" Style="{StaticResource StatsCaptionLabel}"/>
                </StackLayout>

                <StackLayout Grid.Column="1">
                    <Label Text="94" Style="{StaticResource StatsNumberLabel}"/>
                    <Label Text="Following" Style="{StaticResource StatsCaptionLabel}"/>
                </StackLayout>

                <StackLayout Grid.Column="2">
                    <Label Text="957" Style="{StaticResource StatsNumberLabel}"/>
                    <Label Text="Followers" Style="{StaticResource StatsCaptionLabel}"/>
                </StackLayout>
           </Grid>

            <!-- profile description -->
            <ScrollView Grid.Row="3">
                <Label Margin="20,0" HorizontalTextAlignment="Center" Style="{StaticResource MainBodyLabel}" 
                Text="Spicy jalapeno bacon ipsum dolor amet pork loin pork sint sed occaecat swine ham capicola deserunt pork belly frankfurter magna drumstick." />
            </ScrollView>

            <!-- follow button -->
            <Button Grid.Row="4" Text="Follow" Margin="20" VerticalOptions="End" Style="{StaticResource FollowButton}"/>

        </Grid>
    </ScrollView>
</ContentPage>
```

## A little bit of Style

You'll notice that I use Styles throughout the page.  This is really important so you are hard coding values all around the place. The basic structure of my ResourceDictionary is normally

```xml
<!-- Application resource dictionary -->
<ResourceDictionary>
    <!-- colors -->
    <!-- font families -->
    <!-- fonts -->
    <!-- styles -->
</ResourceDictionary>
```

### Colours
specify the colours I use throughout the system. Of course, this makes it nice and easy to change later on.

```xml
<!-- colors -->
<Color x:Key="HeaderTextColor">#585858</Color>
<Color x:Key="BodyTextColor">#C3C3C3</Color>
<Color x:Key="ButtonBackgroundColor">#5992FF</Color>
```

### Font Families
Specifying font famalies for each platform allow me to specify the base fonts used for differnet weights and on different platforms. This makes it dead simple to change the fonts across the application if required.

```xml
<!-- font families -->
<OnPlatform x:Key="RegularFontFamily" x:TypeArguments="x:String"
            iOS="HelveticaNeue"
            Android="sans-serif" />
<OnPlatform x:Key="LightFontFamily" x:TypeArguments="x:String"
            iOS="HelveticaNeue-Light"
            Android="sans-serif-light" />
<OnPlatform x:Key="MediumFontFamily" x:TypeArguments="x:String"
            iOS="HelveticaNeue-Medium"
            Android="sans-serif-medium" />
```

### Fonts
Specifying the fonts allows me to create basic font types which incorporate FontSize and FontFamily, which references the font families already defined in resource dictionary.
```xml
<!-- fonts -->
<Font x:Key="TitleFont" FontSize="20" FontFamily="{StaticResource MediumFontFamily}" />
<Font x:Key="BodyFont" FontSize="18" FontFamily="{StaticResource RegularFontFamily}" />
<Font x:Key="TagTextFont" FontSize="18" FontFamily="{StaticResource RegularFontFamily}" />
<Font x:Key="StatsNumberFont" FontSize="20" FontFamily="{StaticResource LightFontFamily}" />
<Font x:Key="StatsCaptionFont" FontSize="16" FontFamily="{StaticResource LightFontFamily}" />
<Font x:Key="ButtonFont" FontSize="14" FontFamily="{StaticResource MediumFontFamily}" />
```

### Styles
And finally we have the styles, these are the various styles for elements I want to use throughout the application.  This basically brings together colours and Fonts into styles which I can apply to my elements.

```xml
<!-- Styles -->
<Style x:Key="ProfileNameLabel" TargetType="Label">
    <Setter Property="TextColor" Value="{StaticResource HeaderTextColor}" />
    <Setter Property="Font" Value="{StaticResource TitleFont}" />
</Style>

<Style x:Key="ProfileTagLabel" TargetType="Label">
    <Setter Property="TextColor" Value="{StaticResource BodyTextColor}" />
    <Setter Property="Font" Value="{StaticResource TagTextFont}" />
</Style>

<Style x:Key="StatsNumberLabel" TargetType="Label">
    <Setter Property="TextColor" Value="{StaticResource HeaderTextColor}" />
    <Setter Property="HorizontalTextAlignment" Value="Center"/>
    <Setter Property="Font" Value="{StaticResource StatsNumberFont}" />
</Style>

<Style x:Key="StatsCaptionLabel" TargetType="Label">
    <Setter Property="TextColor" Value="{StaticResource BodyTextColor}" />
    <Setter Property="Margin" Value="0,-5,0,0"/>
    <Setter Property="HorizontalTextAlignment" Value="Center"/>
    <Setter Property="Font" Value="{StaticResource StatsCaptionFont}" />
</Style>

<Style x:Key="MainBodyLabel" TargetType="Label">
    <Setter Property="TextColor" Value="{StaticResource BodyTextColor}" />
    <Setter Property="Font" Value="{StaticResource BodyFont}" />
</Style>

<Style x:Key="FollowButton" TargetType="Button">
    <Setter Property="BackgroundColor" Value="{StaticResource ButtonBackgroundColor}"/>
    <Setter Property="TextColor" Value="White"/>
    <Setter Property="HeightRequest" Value="40"/>
    <Setter Property="BorderRadius" Value="20"/>
    <Setter Property="Font" Value="{StaticResource ButtonFont}"/>
</Style>
```

## More to come
So that's a a quick sample of how to do a pretty common layout in Xamarin.Forms with grids and some overlapping elements.  Always remember, there are lots of different ways we could achieve the same layout, but this what sprang to mind.

I've got a whole series of layouts I'll be posting over the comming weeks to show different layout techniques and ideas. 

As YouTubers would say: "let me know in the comments if you liked this" :)  Also, If you have any layouts that you thing would be interesting to cover, just let me know.

Happy Layouts!

Oh yeah, and you can grab the project over at [https://github.com/kphillpotts/XamarinFormsLayoutChallenges](https://github.com/kphillpotts/XamarinFormsLayoutChallenges)
