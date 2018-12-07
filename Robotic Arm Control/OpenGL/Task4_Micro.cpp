#include <stdlib.h>
#include <GL/glut.h>
#include <iostream>
#include "SerialPort.h"
#include <stdio.h>
#include <string.h>

using namespace std;

using std::string;
using std::cout;
using std::endl;

static int w_angle = 0, f1_angle = 0, f2_angle = 0, f3_angle = 0;
char* portName = "\\\\.\\COM6";

#define MAX_DATA_LENGTH 255

char comingData[MAX_DATA_LENGTH];

int windowWidth = 1024;
int windowHeight = 768;
float aspect = float(windowWidth) / float(windowHeight);

//camera posiition x
GLfloat x_pos = 2.0;
//camera posiition y
GLfloat y_pos = 1.0;
//camera posiition z
GLfloat z_pos = -1.5;

//Camera Co-Ords
double eye[] = { 0, 0, 1 };
double center[] = { 0, 0, 0 };
double up[] = { 0, 1, 0 };

void init(void)
{
	glClearColor(0.0, 0.0, 0.0, 0.0);
	glShadeModel(GL_FLAT);
	glEnable(GL_COLOR_MATERIAL);
}



void display(void)
{
	glClear(GL_COLOR_BUFFER_BIT);

	glPushMatrix();
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	gluLookAt(x_pos, y_pos, z_pos, 0, 0.5, 0, 0, 1, 0);

	glPushMatrix();

	//WRIST 

	glTranslatef(1.0, 0.0, 0.0);
	glRotatef((GLfloat)w_angle, 0.0, 0.0, 1.0);
	glTranslatef(-1.0, 0.0, 0.0);
	glTranslatef(.4, 0, 0);
	glColor3f(192, 192, 192);
	glPushMatrix();
	glScalef(0.5, 0.4, .4);
	glutWireCube(1.0);
	glPopMatrix();

	glTranslatef(-0.05, 0, 0.1);

	//F1
	//part 1

	glPushMatrix();
	glTranslatef(.4, 0.15, 0.0);
	glTranslatef(.1, 0, 0);
	glRotatef((GLfloat)f1_angle, 0.0, 0.0, 1.0);
	glTranslatef(-.1, 0, 0);
	glColor3f(128, 0, 128);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();

	//pt2

	glTranslatef(.2, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	glPopMatrix();

	//F2
	//1

	glPushMatrix();
	glTranslatef(0.4, 0.15, -.13);
	glTranslatef(.1, 0, 0);
	glRotatef((GLfloat)f2_angle, 0.0, 0.0, 1.0);
	glTranslatef(-.1, 0, 0);
	glColor3f(0, 206, 209);

	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();

	//2
	glTranslatef(.1, 0.0, 0.0);
	glTranslatef(.1, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	glPopMatrix();

	//F3
	//1

	glPushMatrix();
	glTranslatef(0.4, 0.15, -0.26);
	glTranslatef(.1, 0, 0);
	glRotatef((GLfloat)f3_angle, 0.0, 0.0, 1.0);
	glTranslatef(-.1, 0, 0);
	glColor3f(255, 69, 0);

	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();

	//3

	glTranslatef(.1, 0.0, 0.0);
	glTranslatef(.1, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	glPopMatrix();

	//F4
	//part 1


	glPushMatrix();
	glTranslatef(.4, -.15, 0);
	glTranslatef(-.4, -.15, -.4);
	glRotatef((GLfloat)-f1_angle, 0.0, 0.0, 1.0);
	glTranslatef(.4, 0.15, .4);
	glColor3f(128, 0, 128);

	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();

	//3

	glTranslatef(.2, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	glPopMatrix();
	glPopMatrix();


	glFlush();
	glutSwapBuffers();
}

static int bufferToInt(const char* number)
{
	char stackbuf[6];
	strncpy(stackbuf, number, 6);
	return atoi(stackbuf);
}

void MoveFingers(int key) {

	if (key == 1) {
		if (f1_angle <= 0) {
			f1_angle = (f1_angle - 3);
			if (f1_angle <= -12)
			{
				f1_angle = -12;
			};
			glutPostRedisplay();
		}
		else {
			f1_angle = 0;
		}
		glutPostRedisplay();
	}
	else if (key == 2) {
		if (f2_angle <= 0) {
			f2_angle = (f2_angle - 5);
			if (f2_angle <= -25)
			{
				f2_angle = -25;
			};
			glutPostRedisplay();
		}
		else {
			f2_angle = 0;
		}
		glutPostRedisplay();
	}
	else if (key == 3) {
		if (f3_angle <= 0) {
			f3_angle = (f3_angle - 5);
			if (f3_angle <= -25)
			{
				f3_angle = -25;
			};
			glutPostRedisplay();
		}
		else {
			f3_angle = 0;
		}
		glutPostRedisplay();
	}
	else if (key == 4) {
		if (f1_angle == 0) {
			f1_angle = (f1_angle + 10);
			f2_angle = (f2_angle + 5);
			glutPostRedisplay();
		}
		else {
			f1_angle = 0;
			f2_angle = 0;
		}
		glutPostRedisplay();
	}
	else
	{
		//RESET
		if (f1_angle < 0 || f1_angle > 0) {
			f1_angle = 0;
		}
		if (f2_angle < 0 || f2_angle > 0) {

			f2_angle = 0;
		}
		if (f3_angle < 0 || f3_angle > 0) {

			f3_angle = 0;
		}
		//STOP
	}

	glutPostRedisplay();

}

void Timer1(int x)
{
	SerialPort arduino(portName);
	if (arduino.isConnected())

		//Check if data has been read or not
		int checkSending = arduino.readSerialPort(comingData, MAX_DATA_LENGTH);

	//convert buffer into integer number
	int key1 = bufferToInt(comingData);

	MoveFingers(key1);

	glutPostRedisplay();
	glutTimerFunc(0, Timer1, 0);
}


int main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(500, 500);
	glutInitWindowPosition(100, 100);
	glutCreateWindow(argv[0]);
	init();
	glutDisplayFunc(display);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluPerspective(80, aspect, 0, 10);
	glutTimerFunc(0, Timer1, 0);
	glutMainLoop();
	return 0;
}