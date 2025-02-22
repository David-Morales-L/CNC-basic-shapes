# CNC Laser G-code Generator

This C# program generates G-code instructions for a CNC laser machine to cut basic geometric shapes: squares, circles, and triangles. The user selects a shape, and the program outputs a G-code file (`output.gcode`) with the necessary instructions to guide the CNC machine.

## Features

- Supports three basic shapes:
  - Square
  - Circle
  - Triangle
- Generates G-code for precise CNC laser cutting
- Simple console-based user interface
- Outputs a ready-to-use G-code file

## CNC Use
CNC (Computer Numerical Control) machines are widely used in the industry for precision cutting of various materials, including metal, wood, acrylic, and plastic. These machines follow programmed G-code instructions to create intricate designs with high accuracy and repeatability. CNC laser cutters, in particular, use a focused laser beam to cut or engrave materials, offering clean edges and minimal material waste. They are commonly employed in manufacturing, prototyping, signage, and custom fabrication industries.

![image](https://github.com/user-attachments/assets/319255b0-c939-40ea-bf71-90babbe071c4)
*Dot cutting CNC machine used in the company where I work.*

## Example Output

Here is an example of generated G-code for a square:

```gcode
G21 ; Set units to mm
G90 ; Absolute positioning
M3 ; Turn on laser
G1 X0 Y0 F1000
G1 X50 Y0
G1 X50 Y50
G1 X0 Y50
G1 X0 Y0
M5 ; Turn off laser
```

## Resources & Links

- [Introduction to CNC Laser Cutting](https://example.com/cnc_intro)
- [G-code Reference](https://example.com/gcode_reference)

