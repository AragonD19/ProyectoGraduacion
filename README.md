
# Proyecto: Puzzle RL en Unity con ML-Agents

Este proyecto consiste en un prototipo de videojuego 2D desarrollado en Unity donde un agente (IA) aprende a resolver un entorno tipo puzzle utilizando **aprendizaje por refuerzo** mediante el paquete **ML-Agents**.

---

## 🎯 Objetivo

Entrenar un agente inteligente que, partiendo desde una posición aleatoria, aprenda a alcanzar un objetivo (como una moneda o puerta) evitando salir de los límites del entorno. Con el tiempo, el agente mejora su comportamiento mediante la maximización de recompensas.

---

## ⚙️ Herramientas Utilizadas

- Unity 2021.3 o superior
- ML-Agents Toolkit (v3.0.0)
- Python 3.8/3.9
- TensorFlow / PyTorch (instalado con ML-Agents)
- Visual Studio o VSCode

---

## 📁 Estructura del Proyecto

```
├── Assets/
│   └── Scripts/
│       ├── PuzzleAgent.cs
│       └── Goal.cs
├── config/
│   └── puzzle_rl.yaml
├── README.md
```

---

## 🚀 Instrucciones de Uso

### 1. Instalar ML-Agents

```bash
pip install mlagents
```

### 2. Configurar el proyecto en Unity

- Abrir el proyecto en Unity
- Crear un agente 2D (cuadrado) y una meta (círculo)
- Añadir los scripts: `PuzzleAgent.cs` al agente, `Goal.cs` a la meta
- Agregar el componente `Behavior Parameters` con:
  - Behavior Name: `PuzzleAgent`
  - Action Space: Continuous (2)
  - Observation Space: Vector (4)

### 3. Ejecutar el entrenamiento

```bash
mlagents-learn config/puzzle_rl.yaml --run-id=puzzle_rl_01
```

- Luego haz clic en **Play** en Unity para comenzar

---

## ✅ Resultados Esperados

El agente comenzará moviéndose aleatoriamente y, tras varias iteraciones, aprenderá a dirigirse directamente hacia la meta. Esto demuestra el aprendizaje progresivo por refuerzo.

---

## 📌 Extensiones Posibles

- Añadir obstáculos estáticos o móviles
- Incorporar llaves y puertas para resolver
- Diseñar múltiples niveles con dificultad creciente
- Probar la generalización en salas nuevas

---

## 📜 Licencia

Uso educativo y experimental. Puedes modificar y reutilizar este proyecto libremente con fines académicos.
