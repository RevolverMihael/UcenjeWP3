import Card from './Card.jsx' 
import Card2 from './Card2.jsx'
import Button from './Button/Button.jsx'
import umbrellaSlika from './images/UmbrellaRE.svg'
import Footer from './Footer.jsx'
import Agent from './Agent.jsx'

function App() {
  return(
    <>
    <h1 className='Naslov'>Umbrella Corporation</h1>
    
    <Card />
    <img className='umbrella' src={umbrellaSlika} alt="umbrellaLogo"></img>
    <Card2 />
    <Button />
    <Agent ime="Leon" starost={27} agent={true}/>
    <Footer />
    
    
    </>
  );

 
}

export default App
