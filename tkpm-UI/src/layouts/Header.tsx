function Header() {
  return (        
    <nav className="navbar navbar-light bg-light justify-content-between px-5">
        <a className="navbar-brand" href="/home">2K Home</a>
        <button className="btn btn-outline-success my-2 my-sm-0 rounded-circle border-1" style={{color: "#8fc4b7"}}>
            <i className="bi bi-person-fill"></i>
        </button>
    </nav>
  )
}

export default Header
