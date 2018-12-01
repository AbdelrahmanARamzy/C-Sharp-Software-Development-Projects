// camera movement -- cyrstall ball interface using arrow keys
#include <math.h>
#include "glut.h"


int windowWidth = 1024;
int windowHeight = 768;

float aspect = float(windowWidth) / float(windowHeight);

float spin = 0.0;
bool rotating = false;

double eye[] = { 0, 0, 1 };
double center[] = { 0, 0, 0 };
double up[] = { 0, 1, 0 };


void crossProduct(double a[], double b[], double c[])
{
	c[0] = a[1] * b[2] - a[2] * b[1];
	c[1] = a[2] * b[0] - a[0] * b[2];
	c[2] = a[0] * b[1] - a[1] * b[0];
}

void normalize(double a[])
{
	double norm;
	norm = a[0] * a[0] + a[1] * a[1] + a[2] * a[2];
	norm = sqrt(norm);
	a[0] /= norm;
	a[1] /= norm;
	a[2] /= norm;
}

void rotatePoint(double a[], double theta, double p[])
{

	double temp[3];
	temp[0] = p[0];
	temp[1] = p[1];
	temp[2] = p[2];

	temp[0] = -a[2] * p[1] + a[1] * p[2];
	temp[1] = a[2] * p[0] - a[0] * p[2];
	temp[2] = -a[1] * p[0] + a[0] * p[1];

	temp[0] *= sin(theta);
	temp[1] *= sin(theta);
	temp[2] *= sin(theta);

	temp[0] += (1 - cos(theta))*(a[0] * a[0] * p[0] + a[0] * a[1] * p[1] + a[0] * a[2] * p[2]);
	temp[1] += (1 - cos(theta))*(a[0] * a[1] * p[0] + a[1] * a[1] * p[1] + a[1] * a[2] * p[2]);
	temp[2] += (1 - cos(theta))*(a[0] * a[2] * p[0] + a[1] * a[2] * p[1] + a[2] * a[2] * p[2]);

	temp[0] += cos(theta)*p[0];
	temp[1] += cos(theta)*p[1];
	temp[2] += cos(theta)*p[2];

	p[0] = temp[0];
	p[1] = temp[1];
	p[2] = temp[2];

}

void Left()
{
	double speed = 3.1415 / 8;
	rotatePoint(up, speed, eye);
}

void Right()
{
	double speed = 3.1415 / 8;
	rotatePoint(up, -speed, eye);
}

void Up()
{
	double speed = 3.1415 / 8;
	double rot_axis[3];
	double look[3];

	look[0] = -eye[0];
	look[1] = -eye[1];
	look[2] = -eye[2];

	crossProduct(look, up, rot_axis);

	normalize(rot_axis);

	rotatePoint(rot_axis, speed, eye);

	rotatePoint(rot_axis, speed, up);

}

void Down()
{
	double speed = 3.1415 / 8;
	double rot_axis[3];
	double look[3];

	look[0] = -eye[0];
	look[1] = -eye[1];
	look[2] = -eye[2];

	crossProduct(look, up, rot_axis);

	normalize(rot_axis);

	rotatePoint(rot_axis, -speed, eye);

	rotatePoint(rot_axis, -speed, up);

}

void display(void)
{
	glClearColor(0.0, 0.0, 0.0, 0.0);
	glClear(GL_COLOR_BUFFER_BIT);

	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	gluLookAt(eye[0], eye[1], eye[2], center[0], center[1], center[2], up[0], up[1], up[2]);

	glColor3f(0, 1, 0);
	glClear(GL_COLOR_BUFFER_BIT);
	glPushMatrix();
	glBegin(GL_QUADS);
	//1 wall
	glColor3f(0.7, 0.5, 0.4);
	glVertex3f(0.5, 0.5, 0.0);
	glVertex3f(-0.5, 0.5, 0.0);
	glVertex3f(-0.5, -0.5, 0.0);
	glVertex3f(0.5, -0.5, 0.0);

	//2 wall
	glColor3f(0.5, 0.5, 0.5);
	glVertex3f(0.5, 0.5, 0.0);
	glVertex3f(0.5, -0.5, 0.0);
	glVertex3f(0.5, -0.5, 1.0);
	glVertex3f(0.5, 0.5, 1.0);

	//3 wall
	glColor3f(0.4, 0.7, 0.5);
	glVertex3f(-0.5, 0.5, 0.0);
	glVertex3f(-0.5, 0.5, 1.0);
	glVertex3f(-0.5, -0.5, 1.0);
	glVertex3f(-0.5, -0.5, 0.0);
	
	// elsa2f
	glColor3f(0.7, 0.6, 0.7);
	glVertex3f(0.5, 0.5, 0.0);
	glVertex3f(-0.5, 0.5, 0.0);
	glVertex3f(-0.5, 0.5, 1.0);
	glVertex3f(0.5, 0.5, 1.0);

	// eloda eltanya 1 wall
	glColor3f(0.7, 0.6, 0.3);
	glVertex3f(0.5, 0.5, 1.0);
	glVertex3f(0.5, -0.5, 1.0);
	glVertex3f(0.5, -0.5, 2.0);
	glVertex3f(0.5, 0.5, 2.0);

	//2 wall
	glColor3f(0.2, 0.5, 0.3);
	glVertex3f(0.5, 0.5, 1.0);
	glVertex3f(0.5, 0.5, 2.0);
	glVertex3f(-0.5, 0.5, 2.0);
	glVertex3f(-0.5, 0.5, 1.0);

	//3 wall
	glColor3f(0.1, 0.7, 0.5);
	glVertex3f(0.5, 0.5, 2.0);
	glVertex3f(0.5, -0.5, 2.0);
	glVertex3f(-0.5, -0.5, 2.0);
	glVertex3f(-0.5, 0.5, 2.0);

	//4 wall
	glColor3f(0.1, 0.1, 0.5);
	glVertex3f(-0.5, 0.5, 1.0);
	glVertex3f(-0.5, 0.5, 2.0);
	glVertex3f(-0.5, -0.5, 2.0);
	glVertex3f(-0.5, -0.5, 1.0);

	glEnd();
	glFlush();
	glPopMatrix();

	glFlush();
	glutSwapBuffers();
}
                                    
void specialKeys(int key, int x, int y)
{
	switch (key)
	{
	case GLUT_KEY_LEFT: Left(); break;
	case GLUT_KEY_RIGHT: Right(); break;
	case GLUT_KEY_UP:    Up(); break;
	case GLUT_KEY_DOWN:  Down(); break;
	}

	glutPostRedisplay();
}

int main(void)
{

	glutInitWindowSize(windowWidth, windowHeight);
	//glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutCreateWindow("Cyrstall Ball Interface Example");

	glMatrixMode(GL_PROJECTION);
	gluPerspective(100, aspect, 0, 10);


	glutDisplayFunc(display);
	glutSpecialFunc(specialKeys);

	glutMainLoop();
	return 0;

}

