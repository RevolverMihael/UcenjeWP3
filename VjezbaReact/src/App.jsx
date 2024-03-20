
import Umbrella from '/src/images/UmbrellaRE.svg'
import './App.css'

function App() {
  

  return (
    <>
      <div>
        
        <a href="https://react.dev" target="_blank">
          <img src={Umbrella} className="logo react" alt="Umbrella logo" />
        </a>
      </div>
      <h1>Umbrella Corporation</h1>
      <div className="card">
        
        <p>
          Six years have passed since that horrendous incident...
        </p>
      </div>
      <p className="copyright">
        &copy; {new Date() .getFullYear()} UMBRELLA CORPORATION
      </p>
    </>
  )
}

export default App
