# 🎤 HipHopMusic 🎧

**HipHopMusic** es una aplicación desarrollada con .NET MAUI que presenta un Top 10 de artistas de Hip Hop, permitiendo al usuario explorar su música, ver detalles de canciones y navegar a través de una interfaz moderna y atractiva.

---

## 📱 Funcionalidades

- 🏠 Pantalla de inicio con botón para ingresar a la app.
- 🔝 Vista de los **Top 10 artistas** (nombre, ranking, último álbum, imagen).
- 🎶 Lista de canciones por artista (nombre, imagen alusiva).
- 📝 Vista detallada de cada canción:
  - Año de lanzamiento
  - Duración
  - Letra completa
- 🔙 Navegación entre pantallas (Inicio → Artistas → Canciones → Detalle de Canción).
- 🎨 Interfaz con diseño en tonos **negro y dorado**, estilo hip-hop moderno.

---

## 🧠 Arquitectura utilizada

Se implementa el patrón **MVVM (Model-View-ViewModel)**, ideal para separar lógica de negocio de la interfaz gráfica en aplicaciones MAUI.

---

## 🛠️ Tecnologías empleadas

- [.NET MAUI](https://learn.microsoft.com/dotnet/maui/) — para desarrollo multiplataforma.
- `C#` — lenguaje de programación principal.
- `XAML` — para definir las interfaces visuales.
- `ObservableCollection` y bindings — para la interacción dinámica entre datos y vistas.

---

## 📂 Estructura del proyecto

```plaintext
HipHopMusic/
├── App.xaml                    # Estilos y recursos globales
├── AppShell.xaml              # Definición de rutas y navegación
├── HipHopMusic.csproj         # Configuración del proyecto MAUI
│
├── Models/                    # Modelos de datos
│   ├── Artista.cs
│   └── Cancion.cs
│
├── ViewModels/                # Lógica de negocio y datos
│   ├── ArtistasViewModel.cs
│   └── CancionesViewModel.cs
│
├── Views/                     # Interfaces gráficas
│   ├── InicioPage.xaml
│   ├── ArtistasPage.xaml
│   ├── CancionesPage.xaml
│   └── DetalleCancionPage.xaml
│
├── Resources/
│   └── Images/                # Imágenes asociadas a artistas y canciones
│       ├── eminem.jpg
│       ├── cypresshilluno.jpg
│       └── ...
│
└── README.md                  # Este archivo
