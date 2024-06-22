import React from 'react'

export default function Footer () {
  return (
    <section className="text-stone-300 flex justify-between bg-mountain-mist-500 min-h-32">
      <div className="p-5">
        <span className="text-2xl">CodeProdigee <i className="bi bi-c-circle text-xs"></i></span>
        <span className="ml-2">{new Date().getFullYear()}</span>
      </div>
      <div className="p-5 flex flex-col text-center"> 
        <ul className="flex gap-3">
          <li><a href="" className="hover:text-old-brick-400 hover:cursor-pointer bi bi-twitter-x text-2xl"></a></li>
          <li><a href="" className="hover:text-old-brick-400 hover:cursor-pointer bi bi-github text-2xl"></a></li>
          <li><a href="" className="hover:text-old-brick-400 hover:cursor-pointer bi bi-stack-overflow text-2xl"></a></li>
          <li><a href="" className="hover:text-old-brick-400 hover:cursor-pointer bi bi-discord text-2xl"></a></li>
          <li><a href="" className="hover:text-old-brick-400 hover:cursor-pointer bi bi-linkedin text-2xl"></a></li>
        </ul>
      </div>
      <div className="mr-4 p-5">
        <span className="backToTop text-2xl hover:text-old-brick-400 hover:cursor-pointer bi bi-arrow-up-circle-fill"></span>
      </div>
    </section>
  )
}
