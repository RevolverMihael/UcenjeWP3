import AshleyPic from './images/ashleygraham.png'


function Card2(){

    return(
        <div className="card">
            <img className='card-image' src={AshleyPic} alt="profile picture"></img>
            <h2 className="card-title">Ashley Graham</h2>
            <ul>
                <li className='card-li'>
                Predsjednikova kći koju je oteo vjerski kult u Španjolskoj.
                </li>
            </ul>
            <p></p>            
        </div>

    );

}

export default Card2