#include <math.h>
#include <glut.h>

static int w = 0, e = 0, f = 0;

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


	glPushMatrix();
	// SHOULDER
	glPushMatrix();
	glScalef(2, 0.4, .4);
	glutWireCube(1.0);
	glPopMatrix();
	//ELBOW 
	//JOINT

	glTranslatef(1.0, 0.0, 0.0);
	glRotatef((GLfloat)e, 0.0, 0.0, 1.0);
	glTranslatef(-1.0, 0.0, 0.0);
	glTranslatef(1.2, 0.0, 0.0);
	glPushMatrix();
	glScalef(.4, .4, .4);
	glutWireSphere(.4, 20, 20);
	glPopMatrix();
	//part 2
	glTranslatef(.8, 0.0, 0.0);

	glPushMatrix();
	glScalef(1.2, 0.4, .4);
	glutWireCube(1.0);
	glPopMatrix();
	//WRIST 
	//JOINT
	glTranslatef(1.0, 0.0, 0.0);
	glRotatef((GLfloat)w, 0.0, 0.0, 1.0);
	glTranslatef(-1.0, 0.0, 0.0);
	glTranslatef(.8, 0.0, 0.0);
	glPushMatrix();
	glScalef(.4, 0.4, .4);
	glutWireSphere(.4, 20, 20);
	glPopMatrix();
	//PART2
	glTranslatef(.4, 0, 0);
	glPushMatrix();
	glScalef(.5, 0.4, .4);
	glutWireCube(1.0);
	glPopMatrix();
	//F1
	//part 1
	glTranslatef(.1, 0, 0);
	glRotatef((GLfloat)f, 0.0, 0.0, 1.0);
	glTranslatef(-.1, 0, 0);
	glTranslatef(.4, 0.15, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	//joint

	glTranslatef(.2, -.005, 0);
	glPushMatrix();
	glScalef(.4, 0.4, .4);
	glutWireSphere(.1, 20, 20);
	glPopMatrix();
	//3


	glTranslatef(.2, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	//F2
	//1

	glTranslatef(-.4, -.005, -.15);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	//2
	glTranslatef(.1, 0.0, 0.0);
	glTranslatef(.1, 0.0, 0.0);

	glTranslatef(-.1, 0.0, 0.0);
	glTranslatef(.1, -.005, 0);
	glPushMatrix();
	glScalef(.4, 0.4, .4);
	glutWireSphere(.1, 20, 20);
	glPopMatrix();
	//3
	glTranslatef(.1, 0.0, 0.0);
	glTranslatef(.1, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	//F3
	glTranslatef(1.0, 0.0, 0.0);
	glRotatef(0, 0.0, 0.0, 1.0);
	glTranslatef(-1.4, -.005, 0.25);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	//2

	glTranslatef(.1, 0.0, 0.0);

	glTranslatef(.1, -.005, 0);
	glPushMatrix();
	glScalef(.4, 0.4, .4);
	glutWireSphere(.1, 20, 20);
	glPopMatrix();
	//3

	glTranslatef(.1, 0.0, 0.0);
	glTranslatef(.1, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();

	//F4
	//part 1
	glTranslatef(-.4, -.15, -.4);
	glRotatef((GLfloat)-f, 0.0, 0.0, 1.0);
	glTranslatef(.4, 0.15, .4);
	glTranslatef(-.4, -.25, 0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
	//2

	glTranslatef(.1, 0.0, 0.0);

	glTranslatef(.1, -.005, 0);
	glPushMatrix();
	glScalef(.4, 0.4, .4);
	glutWireSphere(.1, 20, 20);
	glPopMatrix();
	//3


	glTranslatef(.2, -0.005, 0.0);
	glPushMatrix();
	glScalef(.25, 0.1, .1);
	glutWireCube(1.0);
	glPopMatrix();
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
void keyboard(unsigned char key, int x, int y)
{
	switch (key) {
	case '2':
		w = (w + 5);
		if (w >= 90)
		{
			w = 90;
		};
		glutPostRedisplay();
		break;
	case '@':
		w = (w - 5);
		if (w <= -90)
		{
			w = -90;
		};
		glutPostRedisplay();
		break;
	case '1':

		e = (e + 5);
		glutPostRedisplay();
		if (e >= 180)
		{
			e = 180;
		};

		break;
	case '!':

		e = (e - 5);
		glutPostRedisplay();
		if (e <= 0)
		{
			e = 0;
		};


		break;
	case '3':
		f = 30;
		glutPostRedisplay();
		break;
	case '#':
		f = 0;
		glutPostRedisplay();
		break;
	default:
		break;
	}
}



int main(void)
{

	glutInitWindowSize(windowWidth, windowHeight);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutCreateWindow("task1");

	glMatrixMode(GL_PROJECTION);
	gluPerspective(60, aspect, 0, 10);
	glutDisplayFunc(display);
	glutSpecialFunc(specialKeys);
	glutKeyboardFunc(keyboard);
	glutMainLoop();
	return 0;

}