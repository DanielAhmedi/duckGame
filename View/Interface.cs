using System;
using System.Drawing;
using System.Windows.Forms;
using Avalonia;
using Avalonia.Input;
using Avalonia.Media;
using NUnit.Framework;

namespace Manipulation
{
    public static class VisualizerTask
    {
        public static double Xtarget = 220;
        public static double Ytarget = -100;
        public static double AngleAlpha = 0.05;
        public static double WristRot = 2 * Math.PI / 3;
        public static double Cubit = 3 * Math.PI / 4;
        public static double Arm = Math.PI / 2;

        public static Brush UnreachableAreaBrush = new SolidColorBrush(Color.FromArgb(255, 255, 230, 230));
        public static Brush ReachableAreaBrush = new SolidColorBrush(Color.FromArgb(255, 230, 255, 230));
        public static Pen ManipulatorPen = new Pen(Brushes.Black, 3);
        public static Brush JointBrush = new SolidColorBrush(Colors.Gray);

        public static void KeyDown(IDisplay display, KeyEventArgs key)
        {
            if (key.Key == Key.Q) 
                Arm += AngleAlpha;
            else if (key.Key == Key.A) 
                Arm -= AngleAlpha;
            else if (key.Key == Key.W) 
                Cubit += AngleAlpha;
            else if (key.Key == Key.S) 
                Cubit -= AngleAlpha;
            WristRot = -AngleAlpha - Arm - Cubit;
            display.InvalidateVisual();
        }

        public static void MouseMove(IDisplay display, PointerEventArgs e)
        {
            Point shouldPos = GetShoulderPos(display);
            Point point = e.GetPosition(display);
            Point endPoint = ConvertWindowToMath(point, shouldPos);
            Xtarget = endPoint.X;
            Ytarget = endPoint.Y;
            UpdateManipulator();
            display.InvalidateVisual();
        }

        public static void MouseWheel(IDisplay display, PointerWheelEventArgs e)
        {
            AngleAlpha += e.Delta.Y;
            UpdateManipulator();
            display.InvalidateVisual();
        }

        public static void UpdateManipulator()
        {
            var angles = ManipulatorTask.MoveManipulatorTo(Xtarget, Ytarget, AngleAlpha);
            if (angles[0] != double.NaN && angles[1] != double.NaN && angles[2] != double.NaN)
            {
                Arm = angles[0];
                Cubit = angles[1];
                WristRot = angles[2];
            }
        }

        public static void DrawManipulator(DrawingContext context, Point shoulderPos)
        {
            var joints = AnglesToCoordinatesTask.GetJointPositions(Arm, Cubit, WristRot);

            DrawReachableZone(context, ReachableAreaBrush, UnreachableAreaBrush, shoulderPos, joints);

            var formattedText = new FormattedText($"X={Xtarget:0}, Y={Ytarget:0}, Alpha={AngleAlpha:0.00}", Typeface.Default, 18,
                TextAlignment.Center, TextWrapping.Wrap, Size.Empty);
            context.DrawText(Brushes.DarkRed, new Point(10, 10), formattedText);
            for (var i = 0; i < joints.Length; i++)
                ConvertMathToWindow(joints[i], shoulderPos);
            for (var i = 0; i < 2; i++)
                context.DrawLine(ManipulatorPen, joints[i], joints[i + 1]);
            for (var i = 0; i < 3; i++)
                context.DrawEllipse(JointBrush, null, joints[i], 1, 1);
        }

        private static void DrawReachableZone(
            DrawingContext elementContext,
            Brush reachBrush,
            Brush unreachBrush,
            Point shouldPosition,
            Point[] joints)
        {
            var rmin = Math.Abs(Manipulator.UpperArm - Manipulator.Forearm);
            var rmax = Manipulator.UpperArm + Manipulator.Forearm;
            var mathCenter = new Point(joints[2].X - joints[1].X, joints[2].Y - joints[1].Y);
            var windowCenter = ConvertMathToWindow(mathCenter, shouldPosition);
            elementContext.DrawEllipse(reachBrush,
                null,
                new Point(windowCenter.X, windowCenter.Y),
                rmax, rmax);
            elementContext.DrawEllipse(unreachBrush,
                null,
                new Point(windowCenter.X, windowCenter.Y),
                rmin, rmin);
        }

        public static Point GetShoulderPos(IDisplay display)
        {
            return new Point(display.Bounds.Width / 2, display.Bounds.Height / 2);
        }

        public static Point ConvertMathToWindow(Point mathPoint, Point shoulderPos)
        {
            return new Point(mathPoint.X + shoulderPos.X, shoulderPos.Y - mathPoint.Y);
        }

        public static Point ConvertWindowToMath(Point windowPoint, Point shoulderPos)
        {
            return new Point(windowPoint.X - shoulderPos.X, shoulderPos.Y - windowPoint.Y);
        }
    }
}