import PropTypes from 'prop-types'

function Agent(propTypes){
    return(
        <div className="Agent">
            <p>Ime: {propTypes.ime}</p>
            <p>Starost: {propTypes.starost}</p>
            <p>Agent: {propTypes.agent ? "Da" : "Ne"}</p>
        </div>
    );
}
Agent.propTypes={
    ime: PropTypes.string,
    starost: PropTypes.number,
    agent: PropTypes.bool,


}

Agent.defaultProps={
    ime: "nepoznato",
    starost: 0,
    agent: false,

}

export default Agent