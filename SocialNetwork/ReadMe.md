# Social Network App

Everyone loves a curved background header image and an overlayed profile picture on their UI's, right?  Well designers sure do.  

So let's see how to recreate a simple Social Network profile type page in Xamarin.Forms.

> Design

## Basic Layout
Grids are my default layout container for Xamarin.Forms.  They aren't perfect for every situation, but they do provide:

* Proportional sizing of rows and columns, 
* The ability to overlaying controls within a cell, and 
* They resize reasonably

All of which make them pretty useful for a range of designs.


The basic structure of the page is a simple Grid with one column.  Within the cells are stack layouts for some of the text elements that stack on each other, and to provide the three social stats across the page it has a nested grid with three columns.

Using Xamarin Inspector is a pretty good way of looking at the View Hierarchy.

>INSPECTOR IMAGE OF PAGE

## Let's break it down

### Header
The header is just basically an Image that is fills the first row of the Grid.  To get the curve at the bottom you have a couple of options.

#### Option 1: Pre-made Image
You could create your header image with a curve at the bottom like this:

![Curved Header Image](http://link)

The downside of this is that you have to prepare this ahead of time, and may not be appropriate for dynamically loaded images.

#### Option 2: Apply a mask
Instead we can kind of cheat and just add a mask image over the top of the background image.  This is the option I went for here because it provides more flexibility.  We could for example, have different masks for different OS's or different Idioms (eg. Phone, Tablet, Desktop).  The mask image could be anything design you want, but for this I just went for a simple arc, like this (shadow added so you can see the shape).

> Mask Image

It provides a nice effect and the only real downside is that it has to be the same colour as the background

## Profile Image
The profile image is just a simple graphic, but the trick to get it to overlay the background image is with just a couple of settings.

```xml
<Image Source="ProfilePic.png" Margin="0,0,0,-50" HeightRequest="100" WidthRequest="100" HorizontalOptions="Center" VerticalOptions="End"/>
```

* Set the `WidthRequest` and `HeightRequest` to a known value (100 in this case)
* Set the `Margin` to a negative value so that it comes up the page by half of it's height.

And that's it.  

Now I did kind of cheat because I've got a precreated image for this sample, but that's because I just wanted to talk about layout.  In a real app, I highly recommend you use the RoundedImagePlugin from James Montemagno, or use the FFImage Library and apply a rounded effect to the image.

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

<Style x:Key="FollowButton"
    TargetType="Button">
    <Setter Property="BackgroundColor" Value="{StaticResource ButtonBackgroundColor}"/>
    <Setter Property="TextColor" Value="White"/>
    <Setter Property="HeightRequest" Value="40"/>
    <Setter Property="BorderRadius" Value="20"/>
    <Setter Property="Font" Value="{StaticResource ButtonFont}"/>
</Style>
```


## Resizing