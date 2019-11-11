from tkinter import *
from tkinter import ttk
from oct2py import octave, Oct2Py


class App:
    def __init__(self, master):

        # self.octaveClient = Oct2Py(temp_dir="C:/Users/Facundo/PycharmProjects/tpSuperior/dist/app/share/jupyter/kernels/octave") esto esta aca por el tema de generar el exe
        # me parece que tiene que ver con esto
        self.octaveClient = octave
        self.master = master
        # master.title("INTERPOLACION")
        # master.geometry("500x300")

        Label(master, text="Valores de x (seguidos de una coma)").grid(row=0)
        self.textBox1 = Entry(master)
        self.textBox1.grid(row=1, column=0)

        Label(master, text="Valores de y (seguidos de una coma)").grid(row=2)
        self.textBox2 = Entry(master)
        self.textBox2.grid(row=3, column=0)

        self.comboPolinomios = ttk.Combobox(master, state="readonly")
        self.comboPolinomios["values"] = ["Lagrange", "Newton-Gregory Progresivo", "Newton-Gregory Regresivo"]
        Label(master, text="Elija polinomio por el cual interpolar").grid(row=4)
        self.comboPolinomios.grid(row=5, column=0)

        self.buttonCalcularPolinomio = Button(master, text="Hallar Polinomio Interpolante",
                                              command=self.calcularPolinomio)
        self.buttonCalcularPolinomio.grid(row=6, column=0)

        self.lblResultado = Label(master, text="")
        self.lblResultado.grid_forget()

        self.lblPunto = Label(master, text="Ingrese valor de x del punto para evaluar en polinomio hallado")
        self.lblPunto.grid_forget()
        self.textBoxPunto = Entry(master)
        self.textBoxPunto.grid_forget()
        self.lblPunto = Label(master, text="Ingrese valor de x del punto para evaluar en polinomio hallado")
        self.lblPunto.grid_forget()

        self.buttonEvaluarEnPunto = Button(master, text="Evaluar", command=self.evaluarEnPunto)
        self.buttonEvaluarEnPunto.grid_forget()
        self.lblPuntoResultado = Label(master, text="")
        self.lblPuntoResultado.grid_forget()

        self.buttonDetalles = Button(master, text="Mostrar pasos de calculo", command=self.mostrarPasosDeCalculo)
        self.buttonDetalles.grid_forget()

    def calcularPolinomio(self, event=None):
        self.octaveClient.addpath('C:/Users/Facundo/Desktop/octave') #aca se pone ruta donde estan los .m de octave
        text1 = self.textBox1.get()
        xs = list(map(lambda a: float(a), text1.split(",")))
        # print(xs)

        text2 = self.textBox2.get()
        ys = list(map(lambda a: float(a), text2.split(",")))
        # print(ys)

        if self.comboPolinomios.get() == "Newton-Gregory Progresivo":
            polinomio, punto, matriz = self.octaveClient.polNProg(xs, ys, 2, nout=3)
            print(polinomio)
            print(punto)
            print(matriz)
            self.lblResultado.grid(row=8)
            self.lblResultado.config(text="Polinomio Hallado: " + str(polinomio))
            self.lblPunto.grid(row=9, column=0)
            self.textBoxPunto.grid(row=9, column=1)
            self.buttonEvaluarEnPunto.grid(row=10)
            self.lblPuntoResultado.grid(row=11)
            self.buttonDetalles.grid(row=12)

        if self.comboPolinomios.get() == "Newton-Gregory Regresivo":
            polinomio, punto, matriz = self.octaveClient.polNReg(xs, ys, 2, nout=3)
            print(polinomio)
            print(punto)
            print(matriz)
            self.lblResultado.grid(row=8)
            self.lblResultado.config(text="Polinomio Hallado: " + str(polinomio))
            self.lblPunto.grid(row=9, column=0)
            self.textBoxPunto.grid(row=9, column=1)
            self.buttonEvaluarEnPunto.grid(row=10)
            self.lblPuntoResultado.grid(row=11)
            self.buttonDetalles.grid(row=12)

    def evaluarEnPunto(self, event=None):
        # self.octaveClient.addpath('C:/Users/Facundo/Desktop/octave')
        text1 = self.textBox1.get()
        xs = list(map(lambda a: float(a), text1.split(",")))
        # print(xs)

        text2 = self.textBox2.get()
        ys = list(map(lambda a: float(a), text2.split(",")))
        # print(ys)
        if self.comboPolinomios.get() == "Newton-Gregory Progresivo" or self.comboPolinomios.get() == "Newton-Gregory Regresivo":
            polinomio, punto, matriz = self.octaveClient.polNProg(xs, ys, int(self.textBoxPunto.get()), nout=3)
            self.lblPuntoResultado.grid(row=11)
            self.lblPuntoResultado.config(text="P(k): " + str(punto))
            self.buttonDetalles.grid(row=12)

    def mostrarPasosDeCalculo(self, evento=None):
        window = Toplevel(root)

        if self.comboPolinomios.get() == "Newton-Gregory Progresivo":
            lbl = Label(window, text="Matriz de diferencias")
            lbl.grid(row=0, column=0)

            text1 = self.textBox1.get()
            xs = list(map(lambda a: float(a), text1.split(",")))
            text2 = self.textBox2.get()
            ys = list(map(lambda a: float(a), text2.split(",")))

            polinomio, punto, matriz = self.octaveClient.polNProg(xs, ys, 2, nout=3)

            for i in range(len(matriz)):
                for j in range(len(matriz[i])):
                    Label(window, text=str(matriz[i][j])).grid(row=(i+1), column=j)

        if self.comboPolinomios.get() == "Newton-Gregory Regresivo":
            lbl = Label(window, text="Matriz de diferencias")
            lbl.grid(row=0, column=0)

            text1 = self.textBox1.get()
            xs = list(map(lambda a: float(a), text1.split(",")))
            text2 = self.textBox2.get()
            ys = list(map(lambda a: float(a), text2.split(",")))

            polinomio, punto, matriz = self.octaveClient.polNReg(xs, ys, 2, nout=3)

            for i in range(len(matriz)):
                for j in range(len(matriz[i])):
                    Label(window, text=str(matriz[i][j])).grid(row=(i+1), column=j)


root = Tk()
frameRoot = Frame(root)
frameRoot.grid(column=0, row=0, padx=(50, 50), pady=(20, 20))
frameRoot.columnconfigure(0, weight=2)
frameRoot.rowconfigure(0, weight=2)
my_gui = App(frameRoot)
root.mainloop()
