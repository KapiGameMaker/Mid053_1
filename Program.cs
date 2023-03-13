float x1 , y1 , w1 , h1 , minx1 , maxx1 , miny1 , maxy1;
float x2 , y2 , w2 , h2 , minx2 , maxx2 , miny2 , maxy2;
float lengthX = 0 , lengthY = 0 ;

float overLapseArea = 0;

x1 = float.Parse(Console.ReadLine());
y1 = float.Parse(Console.ReadLine());
w1 = float.Parse(Console.ReadLine());
h1 = float.Parse(Console.ReadLine());
x2 = float.Parse(Console.ReadLine());
y2 = float.Parse(Console.ReadLine());
w2 = float.Parse(Console.ReadLine());
h2 = float.Parse(Console.ReadLine());

maxx1 = x1 + w1;
minx1 = x1 - w1;
maxy1 = y1 + h1;
miny1 = y1 - h1;
maxx2 = x2 + w2;
minx2 = x2 - w2;
maxy2 = y2 + h2;
miny2 = y2 - h2;


if(minx1 >= minx2 && minx1 <= maxx2)
{
    if(maxx1 >= maxx2)
    {
        lengthX = maxx2 - minx1;
    }
    else
    {
        lengthX = maxx1 - minx1;
    }
}
else if(minx2 >= minx1 && minx2 <= maxx1)
{
    if(maxx1 >= maxx2)
    {
        lengthX = maxx2 - minx2;
    }
    else
    {
        lengthX = maxx1 - minx2;
    }
}

if(miny1 >= miny2 && miny1 <= maxy2)
{
    if(maxy1 >= maxy2)
    {
        lengthY = maxy2 - miny1;
    }
    else
    {
        lengthY = maxy1 - miny1;
    }
}
else if(miny2 >= miny1 && miny2 <= maxy1)
{
    if(maxy1 >= maxy2)
    {
        lengthY = maxy2 - miny2;
    }
    else
    {
        lengthY = maxy1 - miny2;
    }
}


overLapseArea =  lengthX * lengthY;
Console.WriteLine(overLapseArea + " " + lengthX + " " + lengthY);

if(overLapseArea == 0)
{
    Console.WriteLine("No Overlapping");
}
else if(overLapseArea > 0 && overLapseArea <= 8)
{
    Console.WriteLine("Not Much Overlapping");
}
else Console.WriteLine("Too Much Overlapping");




