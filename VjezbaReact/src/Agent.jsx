
function Agent(propTypes){
    return(
        <div className="Agent">
            <p>Ime: {propTypes.ime}</p>
            <p>Starost: {propTypes.starost}</p>
            <p>Agent: {propTypes.agent ? "Da" : "Ne"}</p>
        </div>
    );
}

export default Agent