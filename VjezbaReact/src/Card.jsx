import LeonPic from './images/Leon Kennedy.jpg'


function Card(){

    return(
        <div className="card">
            <img className='card-image' src={LeonPic} alt="profile picture"></img>
            <h2 className="card-title">Agent Leon Kennedy</h2>
            <ul>
                <li className='card-li'>
                Poznati protagonist iz popularne videoigre Resident Evil 4.
                </li>
            </ul>
            <p></p>            
        </div>

    );

}

export default Card